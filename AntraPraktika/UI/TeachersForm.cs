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

namespace AntraPraktika.UI
{
    public partial class TeachersForm : Form
    {
        private User user;
        public TeachersForm(User user)
        {
            InitializeComponent();
            this.user = user;
            helloTextView.Text = "Hello, "+ user.name + "!";
        }

        private void newEvaluationButton_Click(object sender, EventArgs e)
        {
            newEvaluationForm newEvaluationForm = new newEvaluationForm(user);
            newEvaluationForm.ShowDialog();
        }

        private void myEvaluationButton_Click(object sender, EventArgs e)
        {
            TeachersEvaluationsForm teachersEvaluations = new TeachersEvaluationsForm(user);
            teachersEvaluations.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
