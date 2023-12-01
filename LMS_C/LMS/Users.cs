using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace LMS
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;

        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";
        private void frmUsers_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
            //disabled sa umpisa
            Disable();
            showUsers(lvwAccounts);
        }
        public void Disable()
        {
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtxStudNo.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
        }
        private void addAccount()
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "INSERT into users (user_id, student_number, full_name, email, password) values (@id, @sn, @fn, @email, @pass)";
                    using (cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.Parameters.AddWithValue("@sn", txtxStudNo.Text);
                        cmd.Parameters.AddWithValue("@fn", txtName.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Users Added Succesfully!", "Record Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Users Adding Failed!", "Record Adding Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AreTextboxesEmpty())
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }
            else
            {
                addAccount();
                Disable();
                btnNew.Enabled = true;
                textBoxClear();
                showUsers(lvwAccounts);
            }
        }

        public void GetNextId()
        {
            using (MySqlConnection myconn1 = new MySqlConnection(con))
            {
                myconn1.Open();
                string sql = "SELECT MAX(user_id) + 1 as nextID FROM users";
                using (MySqlCommand cmd = new MySqlCommand(sql, myconn1))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            txtID.Text = rdr["nextID"].ToString();
                        }
                    }
                }

            }
        }
        private void showUsers(ListView listview)
        {
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT * FROM users";

                    lvwAccounts.Items.Clear();
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
        private bool AreTextboxesEmpty()
        {
            if (string.IsNullOrEmpty(txtxStudNo.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                return true;
            }
            return false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GetNextId();
            txtxStudNo.Enabled = true;
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                textBoxClear();
                btnNew.Enabled = true;
                Disable();
            }
        }

        private void lvwAccounts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem itm = lvwAccounts.SelectedItems[0];
            txtID.Text = itm.Text;
            txtxStudNo.Text = itm.SubItems[1].Text;
            txtName.Text = itm.SubItems[2].Text;
            txtEmail.Text = itm.SubItems[3].Text;
            btnEdit.Enabled = true;
            btnNew.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string sql = "UPDATE users SET student_number = '" + txtxStudNo.Text + "', full_name = '" + txtName.Text + "'," +
                    "email ='" + txtEmail.Text + "', password ='" + txtPassword.Text + "' WHERE user_id = " + id;
                myconn = new MySqlConnection(con);
                myconn.Open();
                cmd = new MySqlCommand(sql, myconn);
                cmd.ExecuteNonQuery();
                if (lvwAccounts.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lvwAccounts.SelectedItems[0];
                    // Update the ListView item with the edited data.
                    selectedItem.SubItems[1].Text = txtxStudNo.Text;
                    selectedItem.SubItems[2].Text = txtName.Text;
                    selectedItem.SubItems[3].Text = txtEmail.Text;
                }
                MessageBox.Show("Record updated successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvwAccounts.SelectedItems[0].Selected = false;
                Disable();
                txtID.Enabled = false;
                showUsers(lvwAccounts);
                myconn.Close();
                myconn.Dispose();
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
                ListViewItem selectedItem = lvwAccounts.SelectedItems[0];
                DialogResult rslt = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rslt == DialogResult.Yes)
                {
                    using (MySqlConnection myconn = new MySqlConnection(con))
                    {

                        myconn.Open();
                        string sql = "DELETE FROM users WHERE user_id = @user_id";
                        using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                        {
                            int userId;
                            if (int.TryParse(selectedItem.SubItems[0].Text, out userId))
                            {
                                cmd.Parameters.AddWithValue("@user_id", userId);
                                cmd.ExecuteNonQuery();
                            }

                        }
                    }
                    MessageBox.Show("Record Deleted!");
                    showUsers(lvwAccounts);
                    btnNew.Enabled = true;
                    textBoxClear();
                    Disable();
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Account is Currently Active and Borrowed a Book!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            textBoxEnable();
        }
        private void textBoxEnable()
        {
            txtID.Enabled = true;
            txtxStudNo.Enabled = true;
            txtName.Enabled = true;
            txtEmail.Enabled = true;
        }
        private void textBoxClear()
        {
            txtID.Text = "";
            txtxStudNo.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void lvwAccounts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                btnEdit.Enabled = false;
                btnEdit.Enabled = false;
                btnNew.Enabled = true;
                textBoxClear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
