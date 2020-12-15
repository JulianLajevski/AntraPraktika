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

namespace AntraPraktika.UI
{
    public partial class newTeachersLessonForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public newTeachersLessonForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (lessonsListView.FocusedItem.Selected == true && groupListView.FocusedItem.Selected == true && teachersListView.FocusedItem.Selected == true)
            {
                var confirmation = MessageBox.Show(
            "Are you sure?",
            "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    int indexLesson = this.lessonsListView.SelectedIndices[0];
                    int indexGroup = this.groupListView.SelectedIndices[0];
                    int indexTeacher = this.teachersListView.SelectedIndices[0];

                    if (lessonsListView.Items[indexLesson].Selected && groupListView.Items[indexGroup].Selected && teachersListView.Items[indexTeacher].Selected)
                    {
                        int lessonId = int.Parse(this.lessonsListView.Items[indexLesson].SubItems[0].Text);
                        int groupId = int.Parse(this.groupListView.Items[indexGroup].SubItems[0].Text);
                        int teacherId = int.Parse(this.teachersListView.Items[indexTeacher].SubItems[0].Text);

                        string sql = "INSERT INTO Group_Lessons(Lesson_Id, Group_Id, Teacher_Id) VALUES (@lessonId, @groupId, @teacherId)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@lessonId", lessonId);
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        cmd.Parameters.AddWithValue("@teacherId", teacherId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("Added!");
                }
            }
            else
            {
                MessageBox.Show("No one lesson/group/techer choosed!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newTeachersLessonLoad(object sender, EventArgs e)
        {
            lessonsListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT Id, Title FROM Lessons";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lessonsListView.Items.Add(lv);
            }
            conn.Close();

            groupListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT Id, Title FROM Groups";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                groupListView.Items.Add(lv);
            }
            conn.Close();

            teachersListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT Users.Id, Users.Name, Users.Surname FROM Users WHERE Users.UserType = 2";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString() + dr[2].ToString());

                teachersListView.Items.Add(lv);
            }
            conn.Close();
        }
    }
}
