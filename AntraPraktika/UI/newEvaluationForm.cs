using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntraPraktika.Back;
using System.Data.SqlClient;

namespace AntraPraktika.UI
{
    public partial class newEvaluationForm : Form
    {
        private User user;
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public newEvaluationForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void newEvaluationLoad(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = "SELECT Users.Id,Users.Name, Users.Surname, Groups.Title FROM(((Group_Students " +
                              "INNER JOIN Group_Lessons ON Group_Students.Group_Id = Group_Lessons.Group_Id)" +
                              "INNER JOIN Groups ON Group_Students.Group_Id = Groups.Id)" +
                              "INNER JOIN Users ON Users.Id = Group_Students.Student_Id)" +
                              "WHERE Group_Lessons.Teacher_Id = @teacherId";

            cmd.Parameters.AddWithValue("@teacherId", user.id);
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString()+ " " + dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                studentsListView.Items.Add(lv);
            }
            conn.Close();
        }

        private void saveEvaluationButton_Click(object sender, EventArgs e)
        {
            if (studentsListView.Items.Count != 0)
            {
                if (studentsListView.FocusedItem.Selected == true)
                {
                    var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int index = this.studentsListView.SelectedIndices[0];

                        if (studentsListView.Items[index].Selected)
                        {
                            int lessonId = getTeacherLessonId(int.Parse(this.studentsListView.Items[index].SubItems[0].Text));
                            int studentId = int.Parse(this.studentsListView.Items[index].SubItems[0].Text);

                            string sql = "INSERT INTO Evaluation(Student_Id, Value, Comment, Date, Lesson_Id) VALUES (@studentId, @value, @comment, @date, @lessonId)";
                            cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@studentId", studentId);
                            cmd.Parameters.AddWithValue("@value", valueTextBox.Value);
                            cmd.Parameters.AddWithValue("@comment", commentTextBox.Text);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@lessonId", lessonId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                        MessageBox.Show("Added!" + this.studentsListView.Items[index].SubItems[0].Text);
                    }
                }
                else
                {
                    MessageBox.Show("No one student choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No one student in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int getTeacherLessonId(int studentId)
        {
            string sql = "SELECT Group_Lessons.Lesson_Id FROM ((Group_Lessons " +
                                  "INNER JOIN Group_Students ON Group_Students.Group_Id = Group_Lessons.Group_Id))" +
                                  "WHERE Group_Lessons.Teacher_Id = @teacherId AND Group_Students.Student_Id = @studentId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@teacherId", user.id);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int lessonId = int.Parse(reader["Lesson_Id"].ToString());
                    conn.Close();
                    return lessonId;
                }
            }
           

            throw new Exception("Error with get lesson ID");

        }
    }
}
