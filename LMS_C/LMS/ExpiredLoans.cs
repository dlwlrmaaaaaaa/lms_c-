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
        public int penaltyCount;
        public int user_id;
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
        /*   public void countPenalty()
            {
                try
                {

                    using (MySqlConnection myconn = new MySqlConnection(con))
                    {
                        myconn.Open();
                        string sql = "SELECT COUNT(*) FROM penalty WHERE user_id = @user_id";
                        using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                        {
                            ListViewItem selectedUserId = lvwList.SelectedItems[0];
                            int user_id = int.Parse(selectedUserId.SubItems[0].Text);
                            cmd.Parameters.AddWithValue("@user_id", user_id);
                            penaltyCount = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error sa countOPenalty : " + e.Message);
                }
            }*/

        private void expiredLoans(ListView listview)
        {
            try
            {
                listview.Items.Clear();
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT borrower_return_record.user_id, users.student_number, users.full_name, borrower_return_record.bktitle, borrower_return_record.due_date, borrower_return_record.isPenalty, penalty.return_deadline " +
                         "FROM borrower_return_record " +
                         "INNER JOIN users ON users.user_id = borrower_return_record.user_id " +
                         "LEFT JOIN penalty ON penalty.user_id = borrower_return_record.user_id " +
                         "WHERE borrower_return_record.due_date < NOW() AND borrower_return_record.bk_return_date IS NULL";
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        using (rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
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
                                    if (rdr["return_deadline"] is DBNull)
                                    {
                                        item.SubItems.Add("NULL");
                                    }
                                    else
                                    {
                                        item.SubItems.Add(rdr["return_deadline"].ToString());
                                    }
                                    listview.Items.Add(item);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No expired loans found.");
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

        public int existUser = 0;
        public void checkCurrentPenalty()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT COUNT(user_id), SUM(penalty_count) FROM penalty WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        ListViewItem selectedUserId = lvwList.SelectedItems[0];
                        int user_id = int.Parse(selectedUserId.SubItems[0].Text);
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                existUser = Convert.ToInt32(rdr[0]);
                                if (rdr[1] != DBNull.Value)
                                {
                                    penaltyCount = Convert.ToInt32(rdr[1]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error sa currentPenalty: " + e.Message);
            }
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Click yes to apply penalty.", "Penalty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                try
                {
                    ListViewItem selectedItem = lvwList.SelectedItems[0];
                    checkCurrentPenalty();
                    if (existUser > 0)
                    {
                        using (MySqlConnection myconn1 = new MySqlConnection(con))
                        {
                            myconn1.Open();
                            try
                            {
                                string sql = "UPDATE penalty SET penalty_count = @penalty_count, penalty_date = @date WHERE user_id = @user_id";
                                using (MySqlCommand cmd = new MySqlCommand(sql, myconn1))
                                {
                                    int id = int.Parse(selectedItem.SubItems[0].Text);
                                    DateTime date = DateTime.Now;
                                    cmd.Parameters.AddWithValue("@user_id", id);
                                    cmd.Parameters.AddWithValue("@date", date.AddDays(7));
                                    cmd.Parameters.AddWithValue("@penalty_count", penaltyCount + 1);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (MySqlException eq)
                            {
                                MessageBox.Show("eq -> " + eq.Message);
                            }
                            checkCurrentPenalty();

                            try
                            {
                                string updateSql = "UPDATE borrower_return_record SET isPenalty = @true WHERE user_id = @user_id AND bktitle = @title AND bk_return_date IS NULL";
                                using (MySqlCommand cmd1 = new MySqlCommand(updateSql, myconn1))
                                {
                                    int user_id = int.Parse(selectedItem.SubItems[0].Text);

                                    cmd1.Parameters.AddWithValue("@true", "true");
                                    cmd1.Parameters.AddWithValue("@user_id", user_id);
                                    cmd1.Parameters.AddWithValue("@title", selectedItem.SubItems[3].Text);
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
                            }
                            catch (MySqlException ez)
                            {
                                MessageBox.Show("ez -> " + ez.Message);
                            }
                        }
                        try
                        {

                        }catch(MySqlException y)
                        {
                            MessageBox.Show("y -> " + y.Message);
                        }
                        if (penaltyCount > 2)
                        {
     
                           
                            using (MySqlConnection myconn3 = new MySqlConnection(con))
                            {
                                myconn3.Open();
                                try
                                {
                                    string blacklist = "INSERT INTO blacklisted (user_id, student_number, full_name) VALUES (@user_id, @sn, @fn)";
                                    using (MySqlCommand cmd = new MySqlCommand(blacklist, myconn3))
                                    {
                                        int id = int.Parse(selectedItem.SubItems[0].Text);
                                        cmd.Parameters.AddWithValue("@user_id", id);
                                        cmd.Parameters.AddWithValue("@sn", selectedItem.SubItems[1].Text);
                                        cmd.Parameters.AddWithValue("@fn", selectedItem.SubItems[2].Text);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                catch (MySqlException y)
                                {
                                    MessageBox.Show("y -> " + y.Message);
                                }
                                try
                                {
                                    string update = "UPDATE users SET status = @status WHERE user_id = @user_id";
                                    using (MySqlCommand cmd1 = new MySqlCommand(update, myconn3))
                                    {
                                        int id = int.Parse(selectedItem.SubItems[0].Text);
                                        cmd1.Parameters.AddWithValue("@status", "Blacklisted!");
                                        cmd1.Parameters.AddWithValue("@user_id", id);
                                        cmd1.ExecuteNonQuery();

                                    }
                                }
                                catch (MySqlException yx)
                                {
                                    MessageBox.Show("yx -> " + yx.Message);
                                }
                                try
                                {
                                    string delete = "DELETE FROM borrower_return_record WHERE user_id = @user_id AND bk_return_date IS NULL";
                                    using (MySqlCommand cmd1 = new MySqlCommand(delete, myconn3))
                                    {
                                        int id = int.Parse(selectedItem.SubItems[0].Text);
                                        cmd1.Parameters.AddWithValue("@user_id", id);
                                        int rowAffected = cmd1.ExecuteNonQuery();
                                        if (rowAffected > 0)
                                        {
                                            MessageBox.Show("You have reached " + penaltyCount + " Penalty Count\n Blacklisted Applied" , "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                                catch (MySqlException y)
                                {
                                    MessageBox.Show("y -> " + y.Message);
                                }
                                
                               
                            }
                        }


                    }
                    else
                    {
                        using (MySqlConnection myconn2 = new MySqlConnection(con))
                        {
                            try
                            {
                                myconn2.Open();
                                string sql = "INSERT INTO penalty (user_id, penalty_date, return_deadline) VALUES (@user_id, @date, @rd)";
                                using (MySqlCommand cmd = new MySqlCommand(sql, myconn2))
                                {
                                    int id = int.Parse(selectedItem.SubItems[0].Text);
                                    DateTime date = DateTime.Now;
                                    cmd.Parameters.AddWithValue("@user_id", id);
                                    cmd.Parameters.AddWithValue("@date", date.AddDays(2));
                                    cmd.Parameters.AddWithValue("@rd", date.AddDays(7));
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Ex. " + ex.Message);
                            }

                            try
                            {
                                using (MySqlConnection myconn = new MySqlConnection(con))
                                {
                                    myconn.Open();
                                    string updateSql = "UPDATE borrower_return_record SET isPenalty = @true WHERE user_id = @user_id AND bktitle = @title AND bk_return_date IS NULL";
                                    using (MySqlCommand cmd1 = new MySqlCommand(updateSql, myconn2))
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
                                }
                            }
                            catch (MySqlException eh)
                            {
                                MessageBox.Show("Eh. " + eh.Message);
                            }
                        }
                    }
                    expiredLoans(lvwList);
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
                int id = int.Parse(selectedItem.SubItems[0].Text);
                try
                {
                    using (MySqlConnection myconn1 = new MySqlConnection(con))
                    {
                        myconn1.Open();
                        string sql = "INSERT INTO blacklisted (user_id, student_number, full_name) VALUES (@user_id, @sn, @fn)";
                        using (MySqlCommand cmd = new MySqlCommand(sql, myconn1))
                        {
                            cmd.Parameters.AddWithValue("@user_id", id);
                            cmd.Parameters.AddWithValue("@sn", selectedItem.SubItems[1].Text);
                            cmd.Parameters.AddWithValue("@fn", selectedItem.SubItems[2].Text);
                            cmd.ExecuteNonQuery();
                        }
                        string update = "UPDATE users SET status = @status WHERE user_id = @user_id";
                        using (MySqlCommand cmd1 = new MySqlCommand(update, myconn1))
                        {

                            cmd1.Parameters.AddWithValue("@status", "Blacklisted!");
                            cmd1.Parameters.AddWithValue("@user_id", id);
                            cmd1.ExecuteNonQuery();

                        }
                        string delete = "DELETE * FROM borrower_return_record WHERE user_id = @user_id AND bk_return_date IS NULL";
                        using (MySqlCommand cmd1 = new MySqlCommand(delete, myconn1))
                        {

                            cmd1.Parameters.AddWithValue("@user_id", id);
                            cmd1.ExecuteNonQuery();
                        }
                        string deletefrompending = "DELETE * FROM borrower_record WHERE user_id = @user_id";
                        using (MySqlCommand cmd1 = new MySqlCommand(deletefrompending, myconn1))
                        {
                            cmd1.Parameters.AddWithValue("@user_id", id);
                            int rowAffected = cmd1.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Blacklisting Done!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        private void lvwList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwList.SelectedItems.Count > 0) // Ensure there is at least one selected item
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
