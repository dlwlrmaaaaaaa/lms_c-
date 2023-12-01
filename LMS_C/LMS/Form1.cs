using LMS.Resources;
using MySql.Data.MySqlClient;

namespace LMS
{
    public partial class frmLogin : Form
    {
        private int user_id = -1;
        public frmLogin()
        {
            InitializeComponent();

        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";
        private void frmLogin_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
            this.AcceptButton = btnLogin;
        }
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            signUp.Show();
            this.Hide();
        }

        private void Login()
        {
            string stud_id = txtStudentNum.Text;
            string pass = txtPassword.Text;
            string status = "";    
            try
            {
                using (myconn = new MySqlConnection(con))
                {
                    myconn.Open();

                    using (cmd = new MySqlCommand())
                    {
                        cmd.Connection = myconn;
                        string sql = "";

                        if (txtStudentNum.Text == "admin")
                        {
                            sql = "SELECT * FROM admins WHERE admin_name = @admin_id";
                            cmd.Parameters.AddWithValue("@admin_id", stud_id);
                        }
                        else
                        {

                                sql = "SELECT * FROM users WHERE student_number = @stud_id";
                                cmd.Parameters.AddWithValue("@stud_id", stud_id);
                            
                        }

                        cmd.CommandText = sql;

                        using (rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                string dbPassword = rdr["password"].ToString();

                                // Check if the entered password matches the stored password
                                if (pass == dbPassword)
                                {
                                    if (stud_id == "admin")
                                    {
                                        int admin_id = -1;
                                        admin_id = rdr.GetInt32("admin_id");
                                        frmDashboard dashboard = new frmDashboard(admin_id);
                                        dashboard.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        status = rdr["status"].ToString();
                                        if(status == "Active")
                                        {
                                            string user = rdr["full_name"].ToString();
                                            user_id = rdr.GetInt32("user_id");
                                            frmHome home1 = new frmHome(user_id);
                                            home1.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            MessageBox.Show("You are restricted from logging in!\n Reason: Blacklisted!", "Restricted!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            return;
                                        }
                                     
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("INCORRECT PASSWORD");
                                    pass = "";
                                }
                                rdr.Close();
                            }
                            else
                            {
                                MessageBox.Show("NO ACCOUNT FOUND");
                                stud_id = "";
                                pass = "";
                            }
                            rdr.Close();
                        }
                    }
                    myconn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void txtStudentNum_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentNum.Text, out int number))
            {
                lbl_stud.Text = "Student Number";
            }
            else
            {
                lbl_stud.Text = "Admin";
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string GetStudentNumber()
        {
            return txtStudentNum.Text;
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
    }
}