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
using AntraPraktika.UI;

namespace AntraPraktika
{
    public partial class LoginForm : Form
    {

        private UserRepository userRepository = new UserRepository();
        User loggedUser = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                loggedUser = userRepository.Login(usernameTextBox.Text, passwordTextBox.Text);

                switch (loggedUser.UserType)
                {
                    case UserType.Student:
                        EvaluationStudentForm studentForm = new EvaluationStudentForm(loggedUser);
                        studentForm.ShowDialog();
                        break;
                    case UserType.Teacher:
                        TeachersForm teachersForm = new TeachersForm(loggedUser);
                        teachersForm.ShowDialog();
                        break;
                    case UserType.Admin:
                        AdminForm adminForm = new AdminForm();
                        adminForm.ShowDialog();
                        break;
                }

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        
    }
}
