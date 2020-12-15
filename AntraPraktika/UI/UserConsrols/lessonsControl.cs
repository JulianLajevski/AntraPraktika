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
    public partial class lessonsControl : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public lessonsControl()
        {
            InitializeComponent();
        }

        private void lessonsLoad(object sender, EventArgs e)
        {
            lessonsListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT Lessons.Id, Lessons.Title FROM Lessons";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lessonsListView.Items.Add(lv);
            }
            conn.Close();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            NewLessonFrom newLesson = new NewLessonFrom();
            newLesson.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (lessonsListView.Items.Count != 0)
            {
                if (lessonsListView.FocusedItem.Selected == true)
                {
                    var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int index = this.lessonsListView.SelectedIndices[0];

                        if (lessonsListView.Items[index].Selected)
                        {
                            int lessonId = int.Parse(this.lessonsListView.Items[index].SubItems[0].Text);
                            string sql = "DELETE FROM Group_Lessons WHERE Lesson_Id = @lessonId " +
                                         "DELETE FROM Lessons WHERE Id = @lessonId";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@lessonId", lessonId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Deleted!");
                    }
                }
                else
                {
                    MessageBox.Show("No one lesson choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No lessons in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
