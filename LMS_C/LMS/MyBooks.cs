﻿using MySql.Data.MySqlClient;
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
    public partial class frmMyBooks : Form
    {

        private int user_id;
  
        private string student_number = "";
        public frmMyBooks(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
  
        }
        MySqlConnection myconn;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";

        private void frmMyBooks_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
           
            btnReturn.Enabled = false;
            btnLost.Enabled = false;
            
            ifExist();
            myBooks(listView1);
            getStudentNumber(user_id);
            countLostBook();

        }
        private void getStudentNumber(int id)
        {
            try { 
                    using(MySqlConnection myconn = new MySqlConnection(con))
                {
                    myconn.Open();
                    string sql = "SELECT student_number FROM users WHERE user_id = @user_id";
                        using(MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", id);
                        using(MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                student_number = rdr["student_number"].ToString();
                            }
                        }
                    }
                }

            }catch(Exception e)
            {
                MessageBox.Show("getStudentNumber: " + e.Message);
            }
        }
        private void myBooks(ListView listview)
        {
            try
            {
                listview.Items.Clear();
                using (MySqlConnection con1 = new MySqlConnection(con))
                {
                    con1.Open();
                    string sql = "SELECT borrower_id, books.book_id, title, borrower_return_record.copies, borrow_date, due_date, bk_return_date FROM books" +
                        " INNER JOIN borrower_return_record ON books.book_id = borrower_return_record.book_id WHERE user_id = @userid";
                    using (MySqlCommand cmd1 = new MySqlCommand(sql, con1))
                    {
                        cmd1.Parameters.AddWithValue("@userid", user_id);
                        cmd1.ExecuteNonQuery();

                        

                        using (MySqlDataReader rdr = cmd1.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                if (rdr["bk_return_date"] is DBNull)
                                {
                                    ListViewItem item = new ListViewItem(rdr["borrower_id"].ToString());
                                    item.SubItems.Add(rdr["book_id"].ToString());
                                    item.SubItems.Add(rdr["title"].ToString());
                                    item.SubItems.Add(rdr["copies"].ToString());
                                    item.SubItems.Add(rdr["borrow_date"].ToString());
                                    item.SubItems.Add(rdr["due_date"].ToString());
                                    listview.Items.Add(item);
                                }
                            }
                        }
                    }
                    con1.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MyBooks.cs :    " + ex.Message);
            }

        }

        DateTime date = DateTime.Now;
        private void Return()
        {
            try
            {

                using (MySqlConnection myconn = new MySqlConnection(con))
                {
                    
                    myconn.Open();

                    ListViewItem selectedValue = listView1.SelectedItems[0];
                    string updatenBook = "UPDATE books SET copies = copies + @copies WHERE book_id = @book_id";
                    using (MySqlCommand cmd = new MySqlCommand(updatenBook, myconn))
                    {
                        cmd.Parameters.AddWithValue("@copies", int.Parse(selectedValue.SubItems[3].Text));
                        cmd.Parameters.AddWithValue("@book_id", int.Parse(selectedValue.SubItems[1].Text));
                        cmd.ExecuteNonQuery();
                    }
                    string returnBook = "UPDATE borrower_return_record SET bk_return_date = @date WHERE borrower_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(returnBook, myconn))
                    {
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@id", int.Parse(selectedValue.SubItems[0].Text));
                        cmd.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Returned Succesfully!", "Book's Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myBooks(listView1);


            }
            catch (Exception e)
            {
                MessageBox.Show("Error sa Return Function() : !" + e.Message);
            }


        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Click Yes, To Return Book", "Returning...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == res)
            {
                Return();
                btnReturn.Enabled = false;
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

        private void frmMyBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnReturn.Enabled = true;
            btnLost.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(listView1.SelectedIndices.Count <= 0)
            {
                btnLost.Enabled = false;
                btnReturn.Enabled = false;
            }
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
        public int countLost;
        private void countLostBook()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {

                    myconn.Open();
                    string sql = "SELECT penalty_count FROM penalty WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        using(MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                if (rdr.Read())
                                {
                                    countLost = rdr.GetInt32(0);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error sa countLostBook function: " + e.Message);
            }
        }
        Boolean existed = false;
        private void ifExist()
        {
            try
            {
                using (MySqlConnection myconn = new MySqlConnection(con))
                {

                    myconn.Open();
                    string sql = "SELECT COUNT(*) FROM penalty WHERE user_id = @user_id AND penalty_date > NOW()";
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if(count > 0)
                        {
                            existed = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error sa ifExist function: " + e.Message);
            }
        }
        private void btnLost_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please make sure that you've lost the book before confirming", "Notifcation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ifExist();
                    using (MySqlConnection myconn = new MySqlConnection(con))
                    {

                        myconn.Open();
                        string sql = "INSERT INTO lost_book (book_id, bktitle, student_number, user_id) VALUES (@book_id,@bktitle, @sn, @user_id)  ";
                        using(MySqlCommand cmd = new MySqlCommand(sql, myconn))
                        {
                            ListViewItem selectedbookId = listView1.SelectedItems[0];
                            int bookid = int.Parse(selectedbookId.SubItems[1].Text);
                            cmd.Parameters.AddWithValue("@book_id", bookid);
                            cmd.Parameters.AddWithValue("@bktitle", selectedbookId.SubItems[2].Text);
                            cmd.Parameters.AddWithValue("@sn", student_number);
                            cmd.Parameters.AddWithValue("@user_id", user_id);
                            cmd.ExecuteNonQuery();
                           
                        }
                        string deleteSql = "DELETE FROM borrower_return_record WHERE borrower_id = @b_id";
                        using(MySqlCommand cmd = new MySqlCommand(deleteSql, myconn))
                        {
                            ListViewItem selectedbookId = listView1.SelectedItems[0];
                            cmd.Parameters.AddWithValue("@b_id", selectedbookId.SubItems[0].Text);
                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Lost book filed Success!", "Notfication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (existed)
                        {
                            try
                            {
                                string uppenalty = "UPDATE penalty SET penalty_count = penalty_count + @count, penalty_date = DATE_ADD(penalty_date, INTERVAL @daysToAdd DAY) WHERE user_id = @user_id";
                                using (MySqlCommand cmd = new MySqlCommand(uppenalty, myconn))
                                {
                                    cmd.Parameters.AddWithValue("@user_id", user_id);
                                    cmd.Parameters.AddWithValue("@count", 1);
                                    cmd.Parameters.AddWithValue("@daysToAdd", 15);
                                    cmd.ExecuteNonQuery();
                                }
                                countLostBook();
                                if (countLost >= 3)
                                {
                                    try
                                    {
                                        string delete = "DELETE FROM borrower_return_record WHERE user_id = @user_id AND bk_return_date IS NULL";
                                        using (MySqlCommand cmd = new MySqlCommand(delete, myconn))
                                        {
                                            cmd.Parameters.AddWithValue("@user_id", user_id);
                                            cmd.ExecuteNonQuery();
                                        }
                                        string upsql = "UPDATE users SET status = @status WHERE user_id = @user_id";
                                        using (MySqlCommand cmd = new MySqlCommand(upsql, myconn))
                                        {
                                            cmd.Parameters.AddWithValue("@status", "Blacklisted");
                                            cmd.Parameters.AddWithValue("@user_id", user_id);
                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("You have been blacklisted \n " +
                                                "Reason: you lost 3 Books", "Notfication", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }
                                        this.Hide();
                                        frmLogin login = new frmLogin();
                                        login.Show();
                                    }
                                    catch (MySqlException ey)
                                    {
                                        MessageBox.Show("coubntlostao : " + ey.Message);
                                    }
                                    return;
                                }
                            }
                            catch(MySqlException ee)
                            {
                                MessageBox.Show("uppenalty: " + ee.Message);
                            }
                            existed = false;
                        }
                        else
                        {
                            try
                            {
                                string inspenalty = "INSERT INTO penalty (user_id, penalty_count, penalty_date) VALUE (@user_id, @penalty_count, @penalty_date)";
                                using (MySqlCommand cmd = new MySqlCommand(inspenalty, myconn))
                                {
                                    cmd.Parameters.AddWithValue("@user_id", user_id);
                                    cmd.Parameters.AddWithValue("@penalty_count", 1);
                                    cmd.Parameters.AddWithValue("@penalty_date", date.AddDays(15));
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (MySqlException ea)
                            {
                                MessageBox.Show("inspenalty: " + ea.Message);
                            }
                            
                        }
                        myBooks(listView1);
                       
                    }
                    
                   
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error LostClick: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
