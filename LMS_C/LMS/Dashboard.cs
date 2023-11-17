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
namespace LMS.Resources
{
    public partial class frmDashboard : Form
    {
        private int admin_id;
        public frmDashboard(int admin_id)
        {
            InitializeComponent();
            this.admin_id = admin_id;
        }
        MySqlConnection myconn;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";
        MySqlCommand cmd;
        MySqlDataReader rdr;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateRowCountLabel();
            displayAdminName();
            showUsers(lvwList);
        }
        private void UpdateRowCountLabel()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string countQuery = "SELECT COUNT(*) FROM users";
                    string activeCount = "SELECT SUM(copies) FROM borrower_return_record WHERE bk_return_date IS NULL";
                    string expiredCount = "SELECT COUNT(*) FROM borrower_record WHERE due_date <= @date";
                    using (MySqlCommand cmd = new MySqlCommand(countQuery, myconn))
                    {
                        int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                        // Update the label with the row count
                        lblActiveUsers.Text = rowCount.ToString();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(activeCount, myconn))
                    {

                        int active = Convert.ToInt32(cmd.ExecuteScalar());
                        lblActiveLoans.Text = active.ToString();
                    }
                    DateTime duedate = DateTime.Now;
                    using (MySqlCommand cmd = new MySqlCommand(expiredCount, myconn))
                    {
                        cmd.Parameters.AddWithValue("@date", duedate);
                        int expired = Convert.ToInt32(cmd.ExecuteScalar());
                        lblExpiredLoans.Text = expired.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while counting rows: " + ex.Message);
            }
        }

        private void showUsers(ListView listview)
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT student_number, bktitle, full_name, copies, borrow_date, due_date, bk_return_date FROM borrower_return_record INNER JOIN users ON users.user_id = borrower_return_record.user_id";

                    lvwList.Items.Clear();
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                         
                                while (rdr.Read())
                                {
                                if (rdr["bk_return_date"] is DBNull)
                                {
                                    ListViewItem item = new ListViewItem(rdr["student_number"].ToString());
                                    item.SubItems.Add(rdr["full_name"].ToString());
                                    item.SubItems.Add(rdr["bktitle"].ToString());
                                    item.SubItems.Add(rdr["copies"].ToString());
                                    item.SubItems.Add(rdr["borrow_date"].ToString());
                                    item.SubItems.Add(rdr["due_date"].ToString());
                                    listview.Items.Add(item);
                                }
                                   
                                }
                            
                        }
                        myconn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        private void displayAdminName()
        {
            try
            {
                string sql = "SELECT admin_name FROM admins WHERE admin_id = @admin_id";
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@admin_id", admin_id);
                        cmd.ExecuteNonQuery();
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                lblAdminName.Text = rdr["admin_name"].ToString();
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("displayAdminName:  " + e.Message);
            }
        }
        private void lblSearch_Click(object sender, EventArgs e)
        {
            return;
        }
        private void pnlUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
            this.Hide();
        }
        private void pnlAddBooks_Click(object sender, EventArgs e)
        {

            frmAddBooks addBooks = new frmAddBooks();
            addBooks.Show();
            this.Hide();

        }
        private void pnlIssueBooks_Click(object sender, EventArgs e)
        {
            frmIssueBook issueBook = new frmIssueBook(admin_id);
            issueBook.Show();
            this.Hide();
        }
        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void lblHome_Click(object sender, EventArgs e)
        {
            return;
        }
        private void lblBooks_Click(object sender, EventArgs e)
        {
            return;
        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void pnlManage_Click(object sender, EventArgs e)
        {
            ManageBooks manageBooks = new ManageBooks(admin_id);
            manageBooks.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManageBooks manageBooks = new ManageBooks(admin_id);
            manageBooks.Show();
            this.Hide();
        }
    }
}
