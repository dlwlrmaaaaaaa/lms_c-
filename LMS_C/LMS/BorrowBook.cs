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
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        string con = "Server=localhost;Database=library;Uid=root;pwd=";
        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
            picBook.SizeMode = PictureBoxSizeMode.StretchImage;
            myconn = new MySqlConnection(con);
            myconn.Open();
            // getbookid();
            //  getStudentNumber();

        }

        private void frmBorrowBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                frmHome home = new frmHome(user_id);
                home.Show();
                this.Hide();
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
            DialogResult res = MessageBox.Show("Please click 'YES' to confirm!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (txtCopies.Text != "0")
                {
                    BorrowBook();
                    MessageBox.Show("Successfull! Babye!");
                    frmHome home = new frmHome(user_id);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("There is no Available Copies! Come back Again!", "Not Availaible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }




















        private void lblHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(user_id);
            home.Show();
            this.Hide();
        }
        private void lblSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(user_id);
            search.Show();
            this.Hide();
        }
        private void lblBooks_Click(object sender, EventArgs e)
        {
            frmMyBooks myBooks = new frmMyBooks(user_id);
            myBooks.Show();
            this.Hide();
        }
    }
}
