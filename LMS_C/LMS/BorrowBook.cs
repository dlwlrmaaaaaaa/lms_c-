using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmBorrowBook : Form
    {
        private TextBox txtStudentNum;
        private int book_id;
        private int user_id;
        private string name;
        public int count;
        public int countborrowed;
        public frmBorrowBook(int uid, string id, string lbl, string author, string genre, string ISBN, string Summary, string copies, Image pic)
        {
            InitializeComponent();
            user_id = uid;
            book_id = int.Parse(id);
            txtTitle.Text = lbl;
            txtAuthor.Text = author;
            txtGenre.Text = genre;
            txtISBN.Text = ISBN;
            txtSummary.Text = Summary;
            txtCopies.Text = copies;
            picBook.Image = pic;

            this.txtStudentNum = new TextBox();
            this.ShowInTaskbar = false;
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        string con = "Server=localhost;Database=library;Uid=root;pwd=";
        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
            picBook.SizeMode = PictureBoxSizeMode.StretchImage;
            myconn = new MySqlConnection(con);
            CheckifSuspended();
            CheckIfIdenticalBook();
            checkIfSameBook();
            countBorrowBook();
            CountOfBorrowedBook();
            myconn.Open();
            // getbookid();
            //  getStudentNumber();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure, do you want to cancel?", "Cancelling...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == res)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }
        Boolean isCurrentlyTaking = false;
        private void checkIfSameBook()
        {
            try
            {
                using(MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT user_id, book_id FROM borrower_record WHERE user_id = @user_id and book_id = @book_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Parameters.AddWithValue("@book_id", book_id);
                        using(MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                int u_id = rdr.GetInt32("user_id");
                                int b_id = rdr.GetInt32("book_id");

                                if(user_id == u_id && b_id == book_id)
                                {
                                    isCurrentlyTaking = true;
                                  
                                }
                            }
                        }

                    }
                }


            }catch(MySqlException e)
            {
                MessageBox.Show("ChecksameBook () : " + e.Message);
            }
        }

        private void countBorrowBook()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT COUNT(*) FROM borrower_record WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }


            }
            catch (MySqlException e)
            {
                MessageBox.Show("count of borrowBook () : " + e.Message);
            }
        }

        public int penaltyCount;
        DateTime penaltyDate = DateTime.Now;
        private void CheckifSuspended()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT penalty_count, penalty_date FROM penalty WHERE user_id = @user_id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                penaltyDate = Convert.ToDateTime(rdr["penalty_date"]);
                                // penaltyCount = rdr.GetInt32("penalty_count");
                            }
                        }
                    }

                }
            } catch (MySqlException e)
            {
                MessageBox.Show("Suspended function () : " + e.Message);
            }
        }
        private int id_book;
        private void CheckIfIdenticalBook()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT book_id FROM borrower_return_record WHERE user_id = @user_id AND bk_return_date IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                id_book = rdr.GetInt32("book_id");
                                // penaltyCount = rdr.GetInt32("penalty_count");
                            }
                        }
                    }

                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("CheckIfIdenticalBook () : " + e.Message);
            }
        }

        private void CountOfBorrowedBook()
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {

                    myconn.Open();
                    string sql = "SELECT COUNT(*) FROM borrower_return_record WHERE user_id = @user_id AND bk_return_date IS NULL";
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        countborrowed = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error sa BorrowBook function: " + e.Message);
            }
        }

        DateTime date = DateTime.Now;
        private void BorrowBook()
        {

            try
            {
                using (myconn = new MySqlConnection(con))
                {

                    myconn.Open();
                    string sql = "INSERT INTO borrower_record (user_id, book_id, bktitle, borrow_date, status) VALUES (@user_id, @book_id, @bktitle, @borrow, @status)";
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Parameters.AddWithValue("@book_id", book_id);
                        cmd.Parameters.AddWithValue("@borrow", date);
                        cmd.Parameters.AddWithValue("@bktitle", txtTitle.Text);
                        cmd.Parameters.AddWithValue("@status", "Pending");
                        cmd.ExecuteNonQuery();
                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error sa BorrowBook function: " + e.Message);
            }
        
      
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int totalborrow = 0;
            totalborrow = count + countborrowed;
            if (penaltyDate < date)
            {
                if(id_book != book_id)
                {
                    DialogResult res = MessageBox.Show("Please click 'YES' to confirm!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if(totalborrow >= 3)
                        {
                            MessageBox.Show("You have " + countborrowed + " book/s and " + count + " pending borrow book \n Maximum of 3 Books per transaction", "Reached Maximum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                       if(count >= 3)
                        {
                            MessageBox.Show("You reached the maximum allowed to borrow!", "Maximum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (!isCurrentlyTaking)
                            {

                                if (txtCopies.Text != "0")
                                {
                                    BorrowBook();
                                    MessageBox.Show("Successfull!");
                                }
                                else
                                {
                                    MessageBox.Show("There is no Available Copies! Come back Again!", "Not Availaible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                isCurrentlyTaking = false;
                            }
                            else
                            {
                                MessageBox.Show("You cannot borrow the same book!", "Identical Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            countBorrowBook();
                            checkIfSameBook();
                            CheckIfIdenticalBook();
                        }
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("You cannot borrow the same book", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            else
            {
                DateTime currentDate = DateTime.Now;
                TimeSpan remainingDate = currentDate - penaltyDate;
                MessageBox.Show("You can't borrow book at the moment! The remaining days of suspension is " + remainingDate.Days + " Day/s");
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
