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
    public partial class newStudentForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public newStudentForm()
        {
            InitializeComponent();
        }

        private void newStudentLoad(object sender, EventArgs e)
        {
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
            if (groupListView.FocusedItem.Selected == true)
            {
                var confirmation = MessageBox.Show(
            "Are you sure?",
            "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    int indexGroup = this.groupListView.SelectedIndices[0];

                    if (groupListView.Items[indexGroup].Selected)
                    {
                        int groupId = int.Parse(this.groupListView.Items[indexGroup].SubItems[0].Text);

                        addStudent();
                        int newStudentId = getNewStudentId();
                        addStudentToGroup(newStudentId, groupId);


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

        private void addStudent()
        {
            string sql = "INSERT INTO Users(Name,Surname, Birthdate, Username, Password, UserType) VALUES (@name, @surname, @birthdate, @username, @password, @usertype)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@surname", surnameTextBox.Text);
            cmd.Parameters.AddWithValue("@birthdate", birthdatePicker.Value);
            cmd.Parameters.AddWithValue("@username", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", surnameTextBox.Text);
            cmd.Parameters.AddWithValue("@usertype", 1);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private int getNewStudentId()
        {
            int newStudentId = 0;
            conn.Open();
            cmd.CommandText = "SELECT Users.Id FROM Users WHERE Users.Username = @username";
            cmd.Parameters.AddWithValue("@username", nameTextBox.Text);
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                newStudentId = int.Parse(dr["Id"].ToString());

            }
            conn.Close();
            return newStudentId;
        }

        private void addStudentToGroup(int studentId, int groupId)
        {
            string sql = "INSERT INTO Group_Students(Student_Id, Group_Id) VALUES (@studentId, @groupId)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@groupId", groupId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
