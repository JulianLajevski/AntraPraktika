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
    public partial class EditEvaluationForm : Form
    {
        int value;
        int evaluationId;
        string comment;
        private SqlConnection conn;
        public EditEvaluationForm(int value, string comment, int evaluationId)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
            this.value = value;
            this.comment = comment;
            this.evaluationId = evaluationId;
            valueTextBox.Value = value;
            commentTextBox.Text = comment;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(valueTextBox.Value != value || commentTextBox.Text != comment)
            {
                string sql = "UPDATE Evaluation SET Evaluation.Value = @value, Evaluation.Comment = @comment WHERE Evaluation.Evaluation_Id = @evaluationId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@value", valueTextBox.Value);
                cmd.Parameters.AddWithValue("@comment", commentTextBox.Text);
                cmd.Parameters.AddWithValue("@evaluationId", evaluationId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Evaluation changed!");
            }
            else
            {
                MessageBox.Show("Nothing changed!");
            }
        }
    }
}
