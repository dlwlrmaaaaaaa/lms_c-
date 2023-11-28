
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace LMS
{
    public partial class frmSearch : Form
    {
        public int user_id;
        private PictureBox picBook;
        private string book_id;
        public frmSearch(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            picBook = new PictureBox();
            picBook.Name = "picBook";
            this.Controls.Add(picBook);
        }

        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        DataTable table;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";

        private void frmSearch_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
            showBooks(ListView);
            PopulateGenreComboBox();
        }

        private void showBooks(ListView listview)
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT * FROM books";
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        using (rdr = cmd.ExecuteReader())
                        {
                            table = new DataTable();
                            table.Load(rdr);  // Load data into DataTable

                            if (table.Rows.Count > 0)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    ListViewItem item = new ListViewItem(row["book_id"].ToString());
                                    item.SubItems.Add(row["title"].ToString());
                                    item.SubItems.Add(row["author"].ToString());
                                    item.SubItems.Add(row["genre"].ToString());
                                    item.SubItems.Add(row["ISBN"].ToString());
                                    listview.Items.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(user_id);
            home.Show();
            this.Hide();
        }

        private void lblBooks_Click(object sender, EventArgs e)
        {
            frmMyBooks myBooks = new frmMyBooks(user_id);
            myBooks.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string selectedGenre = cmbCategories.SelectedItem as string;

            ListView.Items.Clear();

            if (string.IsNullOrEmpty(searchText) && string.IsNullOrEmpty(selectedGenre))
            {
                showBooks(ListView);
            }
            else
            {
                SearchBooks(searchText, selectedGenre);
            }
        }

        private void SearchBooks(string searchText, string selectedGenre)
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql;

                    if (!string.IsNullOrEmpty(searchText) && !string.IsNullOrEmpty(selectedGenre))
                    {
                        sql = "SELECT * FROM books WHERE (LOWER(title) LIKE @search OR LOWER(author) LIKE @search OR LOWER(ISBN) LIKE @search) AND genre = @genre";
                    }
                    else if (!string.IsNullOrEmpty(searchText))
                    {
                        sql = "SELECT * FROM books WHERE LOWER(title) LIKE @search OR LOWER(author) LIKE @search OR LOWER(ISBN) LIKE @search";
                    }
                    else if (!string.IsNullOrEmpty(selectedGenre))
                    {
                        sql = "SELECT * FROM books WHERE genre = @genre";
                    }
                    else
                    {
                        sql = "SELECT * FROM books";
                    }

                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                        cmd.Parameters.AddWithValue("@genre", selectedGenre);

                        using (rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                ListViewItem item = new ListViewItem(rdr.GetString(0));
                                item.SubItems.Add(rdr.GetString(1));
                                item.SubItems.Add(rdr.GetString(2));
                                item.SubItems.Add(rdr.GetString(3));
                                item.SubItems.Add(rdr.GetString(4));
                                ListView.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

                    // Convert byte array to Image
                    byte[] imgData = (byte[])bookDataRow["image"];
                    MemoryStream ms = new MemoryStream(imgData);
                    Image img = Image.FromStream(ms);

                    picBook.Image = img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (sender is ListView listView)
            {
                if (listView.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView.SelectedItems[0];

                    int selectedIndex = selectedItem.Index;
                    if (selectedIndex >= 0 && selectedIndex < table.Rows.Count)
                    {
                        DisplayBookInformation(selectedIndex, table);

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

                            using (frmBorrowBook frmBorrowBook = new frmBorrowBook(user_id, book_id, Title, Author, Genre, ISBN, Summary, Copies, picBook.Image))
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
            }
        }

        private void PopulateGenreComboBox()
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT DISTINCT genre FROM books";
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        using (rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                string genre = rdr.GetString(0);
                                cmbCategories.Items.Add(genre);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the selection change in the ComboBox
            string selectedGenre = cmbCategories.SelectedItem as string;

            ListView.Items.Clear();
            SearchBooks(txtSearch.Text.Trim().ToLower(), selectedGenre);
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(user_id);
            search.Show();
            this.Hide();
        }
        private void DrawPanelBorder(Graphics g, Panel panel)
        {
            Rectangle r = new Rectangle(0, 0, panel.ClientRectangle.Width - 1, panel.ClientRectangle.Height - 1);
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, r);
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlSidebar);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, panel2);
        }
    }
}
