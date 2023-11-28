using LMS.Resources;
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
using System.Xml.Linq;

namespace LMS
{
    public partial class frmAddBooks : Form
    {
        private int admin_id;
        public int user_id;
        public frmAddBooks()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";

        private void frmAddBooks_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
        }
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBook.SizeMode = PictureBoxSizeMode.StretchImage;
                picBook.Image = new Bitmap(open.FileName);
            }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void InsertBook(byte[] image)
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("Insert into books (title, author, genre, ISBN, summary, copies, image) values (@title, @author, @genre, @isbn, @summary, @copies, @image)", myconn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("@genre", txtGenre.Text);
                        cmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                        cmd.Parameters.AddWithValue("@summary", txtSummary.Text);
                        cmd.Parameters.AddWithValue("@copies", txtCopies.Text);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }
        private bool AreTextboxesEmpty()
        {
            if (string.IsNullOrEmpty(txtAuthor.Text) ||
                string.IsNullOrEmpty(txtTitle.Text) ||
                string.IsNullOrEmpty(txtGenre.Text) ||
                string.IsNullOrEmpty(txtISBN.Text) ||
                string.IsNullOrEmpty(txtCopies.Text) ||
                string.IsNullOrEmpty(txtSummary.Text))
            {
                return true;
            }
            return false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (AreTextboxesEmpty())
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Click Yes to Confirm", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (picBook.Image != null)
                {
                    if (result == DialogResult.Yes)
                    {
                        InsertBook(ConvertImageToBytes(picBook.Image));
                        txtAuthor.Text = "";
                        txtTitle.Text = "";
                        txtGenre.Text = "";
                        txtISBN.Text = "";
                        txtCopies.Text = "";
                        txtSummary.Text = "";
                        picBook.Image = null;
                        MessageBox.Show("Books Added!");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select an image for the book.");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtAuthor.Text = "";
                txtTitle.Text = "";
                txtGenre.Text = "";
                txtISBN.Text = "";
                txtCopies.Text = "";
                txtSummary.Text = "";
                picBook.Image = null;
            }
        }
    }
}
