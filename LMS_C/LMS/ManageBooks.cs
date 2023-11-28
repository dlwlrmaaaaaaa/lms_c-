using LMS.Resources;
using MySql.Data.MySqlClient;
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
    public partial class ManageBooks : Form
    {
        private int admin_id;
        public ManageBooks(int admin_id)
        {
            InitializeComponent();
            this.admin_id = admin_id;
            this.ShowInTaskbar = false;
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;

        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
            //disabled sa umpisa
            Disable();
            showBooks(lvwBooks);
        }

        public void Disable()
        {
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthor.Enabled = false;
            txtGenre.Enabled = false;
            txtISBN.Enabled = false;
            txtCopies.Enabled = false;
            txtSummary.Enabled = false;
        }

        private void textBoxEnable()
        {
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtGenre.Enabled = true;
            txtISBN.Enabled = true;
            txtCopies.Enabled = true;
            txtSummary.Enabled = true;
        }

        private void showBooks(ListView listview)
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT * FROM books";

                    lvwBooks.Items.Clear();
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        using (rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    ListViewItem item = new ListViewItem(rdr.GetString(0));
                                    item.SubItems.Add(rdr.GetString(1));
                                    item.SubItems.Add(rdr.GetString(2));
                                    item.SubItems.Add(rdr.GetString(3));
                                    item.SubItems.Add(rdr.GetString(4));
                                    item.SubItems.Add(rdr.GetString(6));
                                    item.SubItems.Add(rdr.GetString(5));
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

        private void lvwBooks_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem itm = lvwBooks.SelectedItems[0];
            txtID.Text = itm.Text;
            txtTitle.Text = itm.SubItems[1].Text;
            txtAuthor.Text = itm.SubItems[2].Text;
            txtGenre.Text = itm.SubItems[3].Text;
            txtISBN.Text = itm.SubItems[4].Text;
            txtSummary.Text = itm.SubItems[6].Text;
            txtCopies.Text = itm.SubItems[5].Text;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            textBoxEnable();
        }
        private void textBoxClear()
        {
            txtID.Text = " ";
            txtTitle.Text = " ";
            txtAuthor.Text = " ";
            txtGenre.Text = " ";
            txtISBN.Text = " ";
            txtSummary.Text = " ";
            txtCopies.Text = " ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string sql = "UPDATE books SET title = @title, author = @author, genre = @genre, ISBN = @isbn, summary = @summary, copies = @copies WHERE book_id = @id";
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    cmd = new MySqlCommand(sql, myconn);

                    // Use parameters to avoid SQL injection and improve security
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@summary", txtSummary.Text);
                    cmd.Parameters.AddWithValue("@copies", txtCopies.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    // Update the ListView item with the edited data
                    if (lvwBooks.SelectedItems.Count > 0)
                    {
                        ListViewItem selectedItem = lvwBooks.SelectedItems[0];
                        selectedItem.SubItems[1].Text = txtTitle.Text;
                        selectedItem.SubItems[2].Text = txtAuthor.Text;
                        selectedItem.SubItems[3].Text = txtGenre.Text;
                        selectedItem.SubItems[4].Text = txtISBN.Text;
                        selectedItem.SubItems[5].Text = txtSummary.Text;
                        selectedItem.SubItems[6].Text = txtCopies.Text;
                    }

                    MessageBox.Show("Record updated successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvwBooks.SelectedItems[0].Selected = false;
                    Disable();
                    textBoxClear();
                    showBooks(lvwBooks);
                    myconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwBooks.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lvwBooks.SelectedItems[0];
                    DialogResult rslt = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rslt == DialogResult.Yes)
                    {
                        using (MySqlConnection myconn = new MySqlConnection(con))
                        {
                            myconn.Open();
                            string sql = "DELETE FROM books WHERE book_id = @book_id";
                            using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                            {
                                int bookID;
                                if (int.TryParse(selectedItem.SubItems[0].Text, out bookID))
                                {
                                    cmd.Parameters.AddWithValue("@book_id", bookID);
                                    cmd.ExecuteNonQuery();
                                    selectedItem.Remove();
                                }
                            }
                        }
                        MessageBox.Show("Record Deleted!");
                        Disable();
                        textBoxClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmManageBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                textBoxClear();
                Disable();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

