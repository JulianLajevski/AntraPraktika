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
    public partial class newTeacherForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public newTeacherForm()
        {
            InitializeComponent();
        }

        private void newTeacherLoad(object sender, EventArgs e)
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

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
                if (lessonsListView.FocusedItem.Selected == true && groupListView.FocusedItem.Selected == true)
                {
                    var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int indexLesson = this.lessonsListView.SelectedIndices[0];
                        int indexGroup = this.groupListView.SelectedIndices[0];

                        if (lessonsListView.Items[indexLesson].Selected && groupListView.Items[indexGroup].Selected)
                        {
                            int lessonId = int.Parse(this.lessonsListView.Items[indexLesson].SubItems[0].Text);
                            int groupId = int.Parse(this.groupListView.Items[indexGroup].SubItems[0].Text);

                            addTeacher();
                            int newTeacherId = getNewTeacherId();
                            addTeacherGroup(lessonId, groupId, newTeacherId);
                            
                        }
                        MessageBox.Show("Added!");
                    }
                }
                else
                {
                    MessageBox.Show("No one lesson/group choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void addTeacher()
        {
            string sql = "INSERT INTO Users(Name,Surname, Birthdate, Username, Password, UserType) VALUES (@name, @surname, @birthdate, @username, @password, @usertype)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@surname", surnameTextBox.Text);
            cmd.Parameters.AddWithValue("@birthdate", birthdatePicker.Value);
            cmd.Parameters.AddWithValue("@username", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", surnameTextBox.Text);
            cmd.Parameters.AddWithValue("@usertype", 2);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private int getNewTeacherId()
        {
            int newTeacherId = 0;
            conn.Open();
            cmd.CommandText = "SELECT Users.Id FROM Users WHERE Users.Username = @username";
            cmd.Parameters.AddWithValue("@username", nameTextBox.Text);
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                newTeacherId = int.Parse(dr["Id"].ToString());
                
            }
            conn.Close();
            return newTeacherId;
        }
        private void addTeacherGroup(int lessonId, int groupId, int teacherId)
        {
            string sql = "INSERT INTO Group_Lessons(Lesson_Id, Group_Id, Teacher_Id) VALUES (@lessonId, @groupId, @teacherId)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@lessonId", lessonId);
            cmd.Parameters.AddWithValue("@groupId", groupId);
            cmd.Parameters.AddWithValue("@teacherId", teacherId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
