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
    public partial class studentsContol : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public studentsContol()
        {
            InitializeComponent();
        }

        private void studentLoad(object sender, EventArgs e)
        {
            studentsListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT DISTINCT Users.Id, Users.Name, Users.Surname, Users.Birthdate, Groups.Title, Users.Username, Users.Password FROM ((Users " +
                              "INNER JOIN Group_Students ON Group_Students.Student_Id = Users.Id)" +
                              "INNER JOIN Groups ON Groups.Id = Group_Students.Group_Id)";
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
                studentsListView.Items.Add(lv);
            }
            conn.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
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
                            int studentId = int.Parse(this.studentsListView.Items[index].SubItems[0].Text);

                            string sql = "DELETE FROM Group_Students WHERE Group_Students.Student_Id = @studentId " +
                                         "DELETE FROM Users WHERE Users.Id = @studentId";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@studentId", studentId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Deleted!");
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
                MessageBox.Show("No students in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            newStudentForm studentForm = new newStudentForm();
            studentForm.ShowDialog();
        }
    }
}
