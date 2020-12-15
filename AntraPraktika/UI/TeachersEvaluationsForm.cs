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
    public partial class TeachersEvaluationsForm : Form
    {
        private User user;
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public TeachersEvaluationsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void allTeachersEvaluationsLoad(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandText = "SELECT Evaluation.Evaluation_Id, Users.Name, Users.Surname, Evaluation.Value, Evaluation.Comment, Evaluation.Date FROM (((Evaluation " +
                              "INNER JOIN Group_Lessons ON Evaluation.Lesson_Id = Group_Lessons.Lesson_Id)" +
                              "INNER JOIN Users ON Evaluation.Student_Id = Users.Id)" +
                              "INNER JOIN Group_Students ON Group_Lessons.Group_Id = Group_Students.Group_Id AND Evaluation.Student_Id = Group_Students.Student_Id) WHERE Group_Lessons.Teacher_Id = @teacherId";

            cmd.Parameters.AddWithValue("@teacherId", user.id);
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString() + " "+ dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                lv.SubItems.Add(dr[5].ToString());
                teachersEvaluationsList.Items.Add(lv);
            }
            conn.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (teachersEvaluationsList.Items.Count != 0)
            {
                if (teachersEvaluationsList.FocusedItem.Selected == true)
                {
                    var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int index = this.teachersEvaluationsList.SelectedIndices[0];

                        if (teachersEvaluationsList.Items[index].Selected)
                        {
                            int evaluationId = int.Parse(this.teachersEvaluationsList.Items[index].SubItems[0].Text);
                            

                            string sql = "DELETE FROM Evaluation WHERE Evaluation.Evaluation_Id = @evaluationId";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@evaluationId", evaluationId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Deleted!");
                    }
                }
                else
                {
                    MessageBox.Show("No user choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No users in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (teachersEvaluationsList.Items.Count != 0)
            {
                if (teachersEvaluationsList.FocusedItem.Selected == true)
                {
                        int index = this.teachersEvaluationsList.SelectedIndices[0];
                        if (teachersEvaluationsList.Items[index].Selected)
                        {
                            int evaluationId = int.Parse(this.teachersEvaluationsList.Items[index].SubItems[0].Text);
                            int value = int.Parse(this.teachersEvaluationsList.Items[index].SubItems[2].Text);
                            string comment = this.teachersEvaluationsList.Items[index].SubItems[3].Text;

                            EditEvaluationForm editEvaluationForm = new EditEvaluationForm(value, comment, evaluationId);
                            editEvaluationForm.ShowDialog();
                        }
                }
                else
                {
                    MessageBox.Show("No user choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No users in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
