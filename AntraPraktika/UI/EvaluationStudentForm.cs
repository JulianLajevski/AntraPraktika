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
using AntraPraktika.Back;

namespace AntraPraktika.UI
{
    public partial class EvaluationStudentForm : Form
    {
        private User user;
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public EvaluationStudentForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EvaluationStudentLoad(object sender, EventArgs e)
        {
            valuesListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT Lessons.Title, Evaluation.Value, Evaluation.Comment, Evaluation.Date, Users.Name, Users.Surname FROM ((((Evaluation " + 
                                "INNER JOIN Group_Students ON Evaluation.Student_Id = Group_Students.Student_Id )" + 
                                "INNER JOIN Group_Lessons ON Group_Lessons.Lesson_Id = Evaluation.Lesson_Id AND Group_Lessons.Group_Id = Group_Students.Group_Id)" +
                               "INNER JOIN Users ON Group_Lessons.Teacher_Id = Users.Id)" +
                                "INNER JOIN Lessons ON Evaluation.Lesson_Id = Lessons.Id)" +
                                "WHERE Evaluation.Student_Id = @userId";
            cmd.Parameters.AddWithValue("@userId", user.id);
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString()+ " " + dr[5].ToString());
                valuesListView.Items.Add(lv);
            }
            conn.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
