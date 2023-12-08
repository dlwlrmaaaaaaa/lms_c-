using LMS.Resources;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace LMS
{
    public partial class frmIssueBook : Form
    {
        private int admin_id;
        private int user_id;
        Boolean currentlySuspended = false;
        private int book_id ;
        private int borrow_id;
        private string title, copies;
        public frmIssueBook(int admin_id)
        {
            InitializeComponent();
            this.admin_id = admin_id;
            this.ShowInTaskbar = false;
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=";

        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
            showBorrowUser(listView1);
            DisableButton();
        }
        private void DisableButton()
        {
            btnIssue.Enabled = false;
            btnDeny.Enabled = false;
        }
        private void Enable()
        {
            btnIssue.Enabled = true;
            btnDeny.Enabled = true;
        }
        private void showBorrowUser(ListView listview)
        {
            listview.Items.Clear();
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {

                    myconn.Open();
                    string sql = "SELECT borrow_id, users.user_id, book_id, full_name, bktitle, borrow_date FROM borrower_record INNER JOIN users ON borrower_record.user_id = users.user_id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    // user_id = rdr.GetInt32("user_id");
                                    // borrow_id = rdr.GetInt32("borrow_id");
                                    //  book_id = rdr.GetInt32("book_id");
                                    //  title = rdr["bktitle"].ToString();
                                    ListViewItem list = new ListViewItem(rdr["borrow_id"].ToString());
                                    list.SubItems.Add(rdr["user_id"].ToString());
                                    list.SubItems.Add(rdr["book_id"].ToString());
                                    list.SubItems.Add(rdr["full_name"].ToString());
                                    list.SubItems.Add(rdr["bktitle"].ToString());
                                    list.SubItems.Add(rdr["borrow_date"].ToString());
                                    listview.Items.Add(list);
                                }
                            }
                            rdr.Dispose();

                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Issue Books: " + e.Message);
            }
        }
        private void ifSuspended()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT COUNT(*) FROM borrower_return_record WHERE user_id = @id AND due_date < NOW() AND bk_return_date IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@id", user_id);
                         int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            currentlySuspended = true;
                           
                        }

                    }
                }


            }
            catch (MySqlException e)
            {
                MessageBox.Show("sa issuebooks : " + e.Message);
            }
        }
        private void btnDeny_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Click yes to confirm.", "Denying...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == res)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
 
                try
                {
                    using (MySqlConnection myconn = new MySqlConnection(con))
                    {
                        myconn.Open();
                        string deleteToBorrowRecord = "DELETE FROM borrower_record where borrow_id = @borrow";
                        using (MySqlCommand cmd = new MySqlCommand(deleteToBorrowRecord, myconn))
                        {
                            cmd.Parameters.AddWithValue("@borrow", int.Parse(selectedItem.SubItems[0].Text));
                            cmd.ExecuteNonQuery();
                        }
                        string insertToTransaction = "INSERT INTO transactions (admin_id, user_id, book_id, status) VALUES (@admin, @user, @book_id, @status)";
                        using (MySqlCommand cmd1 = new MySqlCommand(insertToTransaction, myconn))
                        {
                            cmd1.Parameters.AddWithValue("@admin", admin_id);
                            cmd1.Parameters.AddWithValue("@user", int.Parse(selectedItem.SubItems[1].Text));
                            cmd1.Parameters.AddWithValue("@book_id", int.Parse(selectedItem.SubItems[2].Text));
                            cmd1.Parameters.AddWithValue("@status", "Denied");
                            cmd1.ExecuteNonQuery();
                        }
                        MessageBox.Show("Issue's Denied!", "Denied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showBorrowUser(listView1);

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Deny Click: " + ex.Message);
                }
            }
        }


        DateTime date = DateTime.Now;
        private void btnIssue_Click(object sender, EventArgs e)
        {
            ifSuspended();
            if (currentlySuspended)
            {
                MessageBox.Show("You cannot issue a suspended User", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentlySuspended = false;
                return;

            }
            DialogResult res = MessageBox.Show("Click yes to confirm.", "Confirming...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == res)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                try
                {
                    using (MySqlConnection myconn1 = new MySqlConnection(con))
                    {
                        myconn1.Open();
                        string sql = "INSERT INTO transactions (admin_id, user_id, book_id, status) VALUES (@admin, @user, @book_id, @status)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, myconn1))
                        {
                            cmd.Parameters.AddWithValue("@admin", admin_id);
                            cmd.Parameters.AddWithValue("@user", int.Parse(selectedItem.SubItems[1].Text));
                            cmd.Parameters.AddWithValue("@book_id", int.Parse(selectedItem.SubItems[2].Text));
                            cmd.Parameters.AddWithValue("@status", "Accepted");
                            cmd.ExecuteNonQuery();
                        }
                    }              
                    using (MySqlConnection myconn2 = new MySqlConnection(con))
                    {
                        myconn2.Open();
                        string check = "SELECT * FROM borrower_return_record WHERE book_id = @book_id AND user_id = @user_id";
                        using (MySqlCommand cmd = new MySqlCommand(check, myconn2))
                        {
                            int bookId;
                            int userId;
                            if (int.TryParse(selectedItem.SubItems[2].Text, out bookId) && int.TryParse(selectedItem.SubItems[1].Text, out userId)){
                                cmd.Parameters.AddWithValue("@book_id", bookId);
                                cmd.Parameters.AddWithValue("@user_id", userId);
                                cmd.ExecuteNonQuery();
                            }
                            using (MySqlDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.HasRows)
                                {
                                    using (MySqlConnection myconn3 = new MySqlConnection(con))
                                    {
                                        myconn3.Open();
                                        string updateSql = "UPDATE borrower_return_record SET copies = copies + 1 WHERE book_id = @book_id AND user_id = @user_id";
                                        using (MySqlCommand cmd1 = new MySqlCommand(updateSql, myconn3))
                                        {
                                            if (int.TryParse(selectedItem.SubItems[0].Text, out userId) && int.TryParse(selectedItem.SubItems[2].Text, out bookId))
                                            {
                                                cmd1.Parameters.AddWithValue("@book_id", bookId);
                                                cmd1.Parameters.AddWithValue("@user_id", userId);
                                                cmd1.ExecuteNonQuery();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    using (MySqlConnection myconn4 = new MySqlConnection(con))
                                    {
                                        myconn4.Open();
                                        string insertSql = "INSERT INTO borrower_return_record (book_id, bktitle , user_id, admin_id, copies, borrow_date, due_date, bk_return_date)" +
                                                " VALUES (@book_id, @title, @userid, @adminid, @copies, @bdate, @duedate, @returndate)";
                                        using (MySqlCommand cmd1 = new MySqlCommand(insertSql, myconn4))
                                        {

                                            if (int.TryParse(selectedItem.SubItems[2].Text, out bookId) && int.TryParse(selectedItem.SubItems[1].Text, out userId))
                                            {
                                                cmd1.Parameters.AddWithValue("@book_id", bookId);
                                                cmd1.Parameters.AddWithValue("@title", selectedItem.SubItems[4].Text);
                                                cmd1.Parameters.AddWithValue("@userid", userId);
                                                cmd1.Parameters.AddWithValue("@adminid", admin_id);
                                                cmd1.Parameters.AddWithValue("@copies", 1);
                                                cmd1.Parameters.AddWithValue("@bdate", date);
                                                cmd1.Parameters.AddWithValue("@duedate", date.AddDays(7));
                                                cmd1.Parameters.AddWithValue("@returndate", null);
                                                cmd1.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                     }
                    using (MySqlConnection myconn5 = new MySqlConnection(con))
                    {
                        myconn5.Open();
                        string deletesql = "DELETE FROM borrower_record WHERE borrow_id = @id";
                        using(MySqlCommand cmd2 =  new MySqlCommand(deletesql, myconn5))
                        {
                            int borrowID;
                            if (int.TryParse(selectedItem.SubItems[0].Text, out borrowID))
                            {
                                cmd2.Parameters.AddWithValue("@id", borrowID);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        string updateBooks = "UPDATE books SET copies = copies - 1 WHERE book_id = @book_id";
                        using(MySqlCommand cmd2 = new MySqlCommand(updateBooks, myconn5))
                        {
                            int bookID;
                            if (int.TryParse(selectedItem.SubItems[2].Text, out bookID))
                            {
                                cmd2.Parameters.AddWithValue("@book_id", bookID);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                    showBorrowUser(listView1);
                    }
                    
                catch (Exception ex)
                {
                    MessageBox.Show("Error sa btnIssueClick() : " + ex.Message);
                }

                MessageBox.Show("Successful!");
                showBorrowUser(listView1);
            }
            else
            {
                return;
            }
        }

        private void listView1_MouseDoubleClick(object sender, EventArgs e)
        {
            Enable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Enable();
            }
            else if (listView1.Items.Count <= 0)
            {
                DisableButton();
            }
            else
            {
                DisableButton();
            }
        }
    }
}
