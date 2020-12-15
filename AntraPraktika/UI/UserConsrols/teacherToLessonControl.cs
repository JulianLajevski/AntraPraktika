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
    public partial class teacherToLessonControl : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public teacherToLessonControl()
        {
            InitializeComponent();
        }

        private void teacherToLessonLoad(object sender, EventArgs e)
        {
            teachersListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT Users.Name, Users.Surname, Groups.Title, Lessons.Title FROM (((Lessons " +
                              "INNER JOIN Group_Lessons ON Group_Lessons.Lesson_Id = Lessons.Id)" + 
                              "INNER JOIN Groups ON Groups.Id = Group_Lessons.Group_Id)" +
                              "INNER JOIN Users ON Users.Id = Group_Lessons.Teacher_Id)";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString() + dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                teachersListView.Items.Add(lv);
            }
            conn.Close();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
           newTeachersLessonForm newTeachersLesson = new newTeachersLessonForm();
            newTeachersLesson.ShowDialog();
        }
    }
}
