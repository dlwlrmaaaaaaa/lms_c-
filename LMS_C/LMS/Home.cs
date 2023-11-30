using LMS.Resources;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class frmHome : Form
    {
        public int user_id;
        public int anotherUserID;
        private Label[] titleLabels;
        private Label[] authorLabels;
        private PictureBox[] picBooks;
        private int numBooks;
        private string book_id;
        private int startBooks = 1;
        public frmHome(int user)
        {
            InitializeComponent();
            user_id = user;
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        MySqlDataAdapter DA;
        DataTable table;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";

        private void frmHome_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
            ifSuspended();          
            displayName();
            string countQuery = "SELECT COUNT(*) FROM books";

            using (cmd = new MySqlCommand(countQuery, myconn))
            {
                numBooks = Convert.ToInt32(cmd.ExecuteScalar());
            }
            titleLabels = new Label[] { lblTitle1, lblTitle2, lblTitle3, lblTitle4, lblTitle5, lblTitle6, lblTitle7, lblTitle8, lblTitle9, lblTitle10 };
            authorLabels = new Label[] { lblAuthor1, lblAuthor2, lblAuthor3, lblAuthor4, lblAuthor5, lblAuthor6, lblAuthor7, lblAuthor8, lblAuthor9, lblAuthor10 };
            picBooks = new PictureBox[] { picBook1, picBook2, picBook3, picBook4, picBook5, picBook6, picBook7, picBook8, picBook9, picBook10 };
            showBooks(startBooks);
            for (int i = 0; i < 10; i++)
            {
                picBooks[i].Click += picBook_Click;
                picBooks[i].Tag = i;
            }
        }

        private void ifSuspended()
        {
            try
            {
                using(MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT COUNT(*) FROM borrower_return_record WHERE user_id = @id AND due_date < NOW() AND bk_return_date IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@id", user_id);


                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                            
                        if(count > 0)
                        {
                            MessageBox.Show("Please Return The Book! You have had borrowed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                       
                    }
                }


            }catch(MySqlException e)
            {
                MessageBox.Show("sa Home : " + e.Message);
            }
        }

        private void showBooks(int startBooks)
        {
            try
            {
                // Clear existing information from PictureBoxes
                for (int i = 0; i < 10; i++)
                {
                    titleLabels[i].Text = "";
                    authorLabels[i].Text = "";
                    picBooks[i].Image = null;
                }
                String sql = "SELECT * FROM books WHERE book_id >= @BookId ORDER BY book_id";
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@BookId", startBooks);
                        DA = new MySqlDataAdapter(cmd);
                        table = new DataTable();
                        DA.Fill(table);
                        int bookIndex = 0;
                        for (int i = 0; i < table.Rows.Count && bookIndex < 10; i++)
                        {
                            titleLabels[bookIndex].Text = table.Rows[i]["title"].ToString();
                            authorLabels[bookIndex].Text = table.Rows[i]["author"].ToString();
                            byte[] img = (byte[])table.Rows[i]["image"];
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                picBooks[bookIndex].Image = Image.FromStream(ms);
                            }
                            bookIndex++;
                        }
                        DA.Dispose();
                    }
                    myconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public string Title;
        public string Author;
        public string Genre;
        public string ISBN;
        public string Copies;
        public string Summary;

        private void DisplayBookInformation(int bookIndex, DataTable table)
        {
            try
            {
                if (table.Rows.Count > 0 && bookIndex >= 0 && bookIndex < table.Rows.Count)
                {
                    DataRow bookDataRow = table.Rows[bookIndex];
                    book_id = bookDataRow["book_id"].ToString();
                    Title = bookDataRow["title"].ToString();
                    Author = bookDataRow["author"].ToString();
                    Genre = bookDataRow["genre"].ToString();
                    ISBN = bookDataRow["ISBN"].ToString();
                    Summary = bookDataRow["summary"].ToString();
                    Copies = bookDataRow["copies"].ToString();
                    byte[] img = (byte[])bookDataRow["image"];
                    MemoryStream ms = new MemoryStream(img);
                    picBooks[bookIndex].Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void picBook_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                int bookIndex = int.Parse(pictureBox.Tag.ToString());
                DisplayBookInformation(bookIndex, table);
                Form formBackground = new Form();
                try
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    using (frmBorrowBook frmBorrowBook = new frmBorrowBook(user_id, book_id, Title, Author, Genre, ISBN, Summary, Copies, picBooks[bookIndex].Image))
                    {
                        frmBorrowBook.Owner = formBackground;
                        frmBorrowBook.ShowDialog();
                        frmBorrowBook.ShowInTaskbar = false;
                    }
                    formBackground.TopMost = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }
            }
        }
        private void displayName()
        {
            try
            {
                using(MySqlConnection mycon = new MySqlConnection(con))
                {
                    mycon.Open();
                    string sql = "SELECT full_name from users WHERE user_id = @userid";
                    using(MySqlCommand cmd = new MySqlCommand(sql, mycon))
                    {
                        cmd.Parameters.AddWithValue("@userid", user_id);
                        cmd.ExecuteNonQuery();
                        using(MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if(rdr.Read())
                            {
                                lblName.Text = rdr["full_name"].ToString();
                            }
                        }
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show("Error in displayName() : " + e.Message);
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(user_id);
            search.Show();
            this.Hide();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
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

        private void lblBooks_Click(object sender, EventArgs e)
        {
            frmMyBooks myBooks = new frmMyBooks(user_id);
            myBooks.Show();
            this.Hide();
        }

        private void DrawPanelBorder(Graphics g, Panel panel)
        {
            Rectangle r = new Rectangle(0, 0, panel.ClientRectangle.Width - 1, panel.ClientRectangle.Height - 1);
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, r);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, panel1);
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlSidebar);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, panel2);
        }

        private void pnlBook1_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlBook1);
        }

        private void pnlBook2_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlBook2);
        }
    }
}