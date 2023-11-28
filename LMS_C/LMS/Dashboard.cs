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

        private void pnlUsers_Click(object sender, EventArgs e)
        {
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

                using (frmUsers frmUsers = new frmUsers())
                {
                    frmUsers.Owner = formBackground;
                    frmUsers.ShowDialog();
                    frmUsers.ShowInTaskbar = false;
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
        private void pnlAddBooks_Click(object sender, EventArgs e)
        {
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

                using (frmAddBooks frmAddBooks = new frmAddBooks())
                {
                    frmAddBooks.Owner = formBackground;
                    frmAddBooks.ShowDialog();
                    frmAddBooks.ShowInTaskbar = false;
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
        private void pnlIssueBooks_Click(object sender, EventArgs e)
        {
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

                using (frmIssueBook frmIssueBook = new frmIssueBook(admin_id))
                {
                    frmIssueBook.Owner = formBackground;
                    frmIssueBook.ShowDialog();
                    frmIssueBook.ShowInTaskbar = false;
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
        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlManage_Click(object sender, EventArgs e)
        {
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

                using (ManageBooks ManageBooks = new ManageBooks(admin_id))
                {
                    ManageBooks.Owner = formBackground;
                    ManageBooks.ShowDialog();
                    ManageBooks.ShowInTaskbar = false;
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

        private void pnlActiveLoans_Click(object sender, EventArgs e)
        {
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

                using (frmActiveLoans frmActiveLoans = new frmActiveLoans())
                {
                    frmActiveLoans.Owner = formBackground;
                    frmActiveLoans.ShowDialog();
                    frmActiveLoans.ShowInTaskbar = false;
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
        private void DrawPanelBorder(Graphics g, Panel panel)
        {
            Rectangle r = new Rectangle(0, 0, panel.ClientRectangle.Width - 1, panel.ClientRectangle.Height - 1);
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, r);
        }

        private void pnlUsers_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlUsers);
        }

        private void pnlActiveLoans_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlActiveLoans);
        }

        private void pnlIssueBooks_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlIssueBooks);
        }

        private void pnlManage_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlManage);
        }

        private void pnlAddBooks_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlAddBooks);
        }

        private void pnlExpiredLoans_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, pnlExpiredLoans);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e.Graphics, panel1);
        }

        private void imgLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void pnlExpiredLoans_Click(object sender, EventArgs e)
        {
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

                using (frmExpiredLoans frmExpiredLoans = new frmExpiredLoans())
                {
                    frmExpiredLoans.Owner = formBackground;
                    frmExpiredLoans.ShowDialog();
                    frmExpiredLoans.ShowInTaskbar = false;
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
