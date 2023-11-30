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

namespace LMS
{
    public partial class frmActiveLoans : Form
    {
        private int admin_id;
        public frmActiveLoans()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        MySqlConnection myconn;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";
        MySqlCommand cmd;
        MySqlDataReader rdr;

        private void frmActiveLoans_Load(object sender, EventArgs e)
        {
            showUsers(lvwList);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmActiveLoans_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
