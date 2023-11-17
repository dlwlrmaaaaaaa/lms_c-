using MySql.Data.MySqlClient;
using System;
namespace LMS
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {

            InitializeComponent();
        }
        MySqlConnection myconn;
        MySqlCommand cmd;
        string con = "Server=localhost;Database=library;Uid=root;Pwd=;";
        private void SignUp_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(con);
            myconn.Open();
        }
        public void Register()
        {
            string studentID = txtStudentNum.Text;
            string fullname = txtFullName.Text;
            string email = txtEmailAdd.Text;

            string password = txtPassword.Text;
            string cpassword = txtConfirmPass.Text;
            if (!(password == cpassword))
            {
                MessageBox.Show("Password Mismatched!", "Password not matched!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Missing Details!", "Fill up information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
         try
            {
                using (myconn = new MySqlConnection(con))
            {
                myconn.Open();
                string sql = "INSERT INTO users (student_number, full_name, email, password) VALUES (@sn, @fn, @e, @pass)";
                using(cmd = new MySqlCommand(sql, myconn))
                {
                    cmd.Parameters.AddWithValue("@sn", studentID);
                    cmd.Parameters.AddWithValue("@fn", fullname);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Succesfully! ", "Record Inserted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured in SignUp Form : " + ex.Message);
            }



        }
        private void lblLogIn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void frmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
