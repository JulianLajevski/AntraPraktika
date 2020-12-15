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

namespace AntraPraktika.UI.UserConsrols
{
    public partial class groupsControl : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=praktika_db;Trusted_Connection=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public groupsControl()
        {
            InitializeComponent();
        }

        private void groupsLoad(object sender, EventArgs e)
        {
            groupsListView.Items.Clear();
            conn.Open();
            cmd.CommandText = "SELECT Groups.Id, Groups.Title FROM Groups";
            cmd.Connection = conn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                groupsListView.Items.Add(lv);
            }
            conn.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (groupsListView.Items.Count != 0)
            {
                if (groupsListView.FocusedItem.Selected == true)
                {
                    var confirmation = MessageBox.Show(
                "Are you sure?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int index = this.groupsListView.SelectedIndices[0];

                        if (groupsListView.Items[index].Selected)
                        {
                            int groupId = int.Parse(this.groupsListView.Items[index].SubItems[0].Text);
                            string sql = "DELETE FROM Group_Students WHERE Group_Id = 9 " +
                                         "DELETE FROM Group_Lessons WHERE Group_Lessons.Group_Id = @groupId " +
                                         "DELETE FROM Groups WHERE Id = @groupId";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@groupId", groupId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Deleted!");
                    }
                }
                else
                {
                    MessageBox.Show("No one group choosed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No group in List!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            newGroupForm newGroup = new newGroupForm();
            newGroup.ShowDialog();
        }
    }
}
