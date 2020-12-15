using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AntraPraktika.UI.UserConsrols
{
    public partial class teachersControl : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public teachersControl()
        {
            InitializeComponent();
        }

        private void teacherLoad(object sender, EventArgs e)
        {
            teachersListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT DISTINCT Users.Id, Users.Name, Users.Surname, Users.Birthdate, Lessons.Title, Users.Username, Users.Password FROM ((Users " +
                              "INNER JOIN Group_Lessons ON Group_Lessons.Teacher_Id = Users.Id)" +
                              "INNER JOIN Lessons ON Lessons.Id = Group_Lessons.Lesson_Id)";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString() + " " + dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                lv.SubItems.Add(dr[5].ToString());
                lv.SubItems.Add(dr[6].ToString());
                teachersListView.Items.Add(lv);
            }
            conn.Close();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            newTeacherForm newTeacher = new newTeacherForm();
            newTeacher.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (teachersListView.Items.Count != 0)
            {
                if (teachersListView.FocusedItem.Selected == true)
                {
                    var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int index = this.teachersListView.SelectedIndices[0];

                        if (teachersListView.Items[index].Selected)
                        {
                            int teacherId = int.Parse(this.teachersListView.Items[index].SubItems[0].Text);

                            string sql = "DELETE FROM Group_Lessons WHERE Group_Lessons.Teacher_Id = @teacherId " +
                                         "DELETE FROM Users WHERE Id = @teacherId";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@teacherId", teacherId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Deleted!");
                    }
                }
                else
                {
                    MessageBox.Show("No one teacher choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No teacher in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
