using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMS
{
    public partial class frmExpiredLoans : Form
    {
        private int admin_id;
        public frmExpiredLoans()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        MySqlConnection myconn;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";
        MySqlCommand cmd;
        MySqlDataReader rdr;
        private void frmExpiredLoans_Load(object sender, EventArgs e)
        {
            expiredLoans(lvwList);
            btnBlacklist.Enabled = false;
            btnPenalty.Enabled = false;

        }

        private void expiredLoans(ListView listview)
        {
            try
            {
                listview.Items.Clear();
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT * FROM borrower_return_record INNER JOIN users ON users.user_id = borrower_return_record.user_id WHERE due_date < NOW() AND bk_return_date IS NULL";
                    using (cmd = new MySqlCommand(sql, myconn))
                    {

                        using (rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                DateTime dueDate = Convert.ToDateTime(rdr["due_date"]);
                                DateTime currentDate = DateTime.Now;
                                TimeSpan overdueSpan = currentDate - dueDate;
                                int overdueDays = overdueSpan.Days;
                                ListViewItem item = new ListViewItem(rdr["user_id"].ToString());
                                item.SubItems.Add(rdr["student_number"].ToString());
                                item.SubItems.Add(rdr["full_name"].ToString());
                                item.SubItems.Add(rdr["bktitle"].ToString());
                                item.SubItems.Add(rdr["due_date"].ToString());                          
                                item.SubItems.Add(overdueDays.ToString());
                                item.SubItems.Add(rdr["isPenalty"].ToString());
                                listview.Items.Add(item);

                            }
                        }

                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error sa expired loans: " + e.Message);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnPenalty_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Click yes to apply penalty.", "Penalty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ListViewItem selectedItem = lvwList.SelectedItems[0];
                try
                {
                    using (MySqlConnection myconn1 = new MySqlConnection(con))
                    {
                        myconn1.Open();
                        string sql = "INSERT INTO penalty (user_id, penalty_count, penalty_date) VALUES (@user_id, @count, @date)";
                        using (MySqlCommand cmd = new MySqlCommand(sql, myconn1))
                        {
                            int id = int.Parse(selectedItem.SubItems[0].Text);

                            DateTime date = DateTime.Now;
                            cmd.Parameters.AddWithValue("@user_id", id);
                            cmd.Parameters.AddWithValue("@count", 1);
                            cmd.Parameters.AddWithValue("@date", date.AddDays(7));
                            cmd.ExecuteNonQuery();


                            //  string deleteFromActiveLoans = "DELETE from "
                        }
                        string updateSql = "UPDATE borrower_return_record SET isPenalty = @true";
                        using (MySqlCommand cmd1 = new MySqlCommand(updateSql, myconn1))
                        {
                            cmd1.Parameters.AddWithValue("@true", "true");
                            int rowsAffected = cmd1.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Penalty Applied!");
                            }
                            else
                            {
                                MessageBox.Show("Penalty Application Failed!");
                            }
                        }
                        expiredLoans(lvwList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("penalty click : " + ex.Message);
                }
            }
            else
            {
                return;
            }
        }
        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("CLICK YES TO BLACKLIST THIS ACCOUNT. NOTE: AFTER BLACKLISTING, THIS ACCOUNT CANNOT BORROW BOOKS PERMANENTLY", "BLACKLISTING..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                ListViewItem selectedItem = lvwList.SelectedItems[0];
                try
                {
                    using (MySqlConnection myconn1 = new MySqlConnection(con))
                    {
                        myconn1.Open();
                        string sql = "INSERT INTO blacklisted (user_id, student_number, full_name) VALUES (@user_id, @sn, @fn)";
                        using (MySqlCommand cmd = new MySqlCommand(sql, myconn1))
                        {
                            int id = int.Parse(selectedItem.SubItems[0].Text);
                            cmd.Parameters.AddWithValue("@user_id", id);
                            cmd.Parameters.AddWithValue("@sn", selectedItem.SubItems[1].Text);
                            cmd.Parameters.AddWithValue("@fn", selectedItem.SubItems[2].Text);
                            cmd.ExecuteNonQuery();
                        }
                        string update = "UPDATE users SET status = @status";
                        using (MySqlCommand cmd1 = new MySqlCommand(update, myconn1))
                        {
                            cmd1.Parameters.AddWithValue("@status", "Blacklisted!");
                            int rowAffected = cmd1.ExecuteNonQuery();
                            if(rowAffected > 0)
                            {
                                MessageBox.Show("Blacklisting Done!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("penalty click : " + ex.Message);
                }
            }
            else
            {
                return;
            }
        }




        private void lvwList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwList.SelectedItems.Count > 0) // Ensure there is at least one selected item
            {
                ListViewItem selectedItem = lvwList.SelectedItems[0];

                if (selectedItem.SubItems.Count > 6) // Check if the item has enough sub-items
                {
                    string subItemText = selectedItem.SubItems[6].Text;

                    if (subItemText == "false")
                    {
                        if (lvwList.SelectedIndices.Count > 0)
                        {
                            btnBlacklist.Enabled = true;
                            btnPenalty.Enabled = true;
                        }
                        else
                        {
                            btnBlacklist.Enabled = false;
                            btnPenalty.Enabled = false;
                        }
                    }
                    else
                    {
                        if (lvwList.SelectedIndices.Count > 0)
                        {
                            btnBlacklist.Enabled = true;
                            btnPenalty.Enabled = false;
                        }
                        else
                        {
                            btnBlacklist.Enabled = false;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                btnBlacklist.Enabled = false;
                btnPenalty.Enabled = false;
            }
        }

        private void lvwList_SelectedIndexChanged(object sender, EventArgs e)
        {

             if (lvwList.SelectedIndices.Count == 0)
            {
                btnBlacklist.Enabled = false;
                btnPenalty.Enabled = false;
            }
         
        }
    }
}
