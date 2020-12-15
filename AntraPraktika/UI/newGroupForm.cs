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
using System.Data.SqlClient;

namespace AntraPraktika.UI
{
    public partial class newGroupForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public newGroupForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Groups (Title) VALUES (@title)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@title", titleTextBox.Text);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added new group!");
        }
    }
}
