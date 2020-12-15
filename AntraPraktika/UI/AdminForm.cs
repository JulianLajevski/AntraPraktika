using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntraPraktika.UI.UserConsrols;

namespace AntraPraktika.UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            groupsControl groups = new groupsControl();
            adminPanel.Controls.Add(groups);
        }

        private void lessonsButton_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            lessonsControl lessons = new lessonsControl();
            adminPanel.Controls.Add(lessons);
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            teachersControl teachers = new teachersControl();
            adminPanel.Controls.Add(teachers);
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            studentsContol students = new studentsContol();
            adminPanel.Controls.Add(students);
        }

        private void teacherLessonsButton_Click(object sender, EventArgs e)
        {
            adminPanel.Controls.Clear();
            teacherToLessonControl teachersLesson = new teacherToLessonControl();
            adminPanel.Controls.Add(teachersLesson);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
