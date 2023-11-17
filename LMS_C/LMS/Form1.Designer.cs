namespace LMS
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            grpLog = new GroupBox();
            lblWelcome = new Label();
            lblSignUp = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtStudentNum = new TextBox();
            lbl_stud = new Label();
            pic1 = new PictureBox();
            grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // grpLog
            // 
            grpLog.BackColor = SystemColors.ButtonHighlight;
            grpLog.Controls.Add(lblWelcome);
            grpLog.Controls.Add(lblSignUp);
            grpLog.Controls.Add(label3);
            grpLog.Controls.Add(btnLogin);
            grpLog.Controls.Add(txtPassword);
            grpLog.Controls.Add(label2);
            grpLog.Controls.Add(txtStudentNum);
            grpLog.Controls.Add(lbl_stud);
            grpLog.Controls.Add(pic1);
            grpLog.Location = new Point(165, 36);
            grpLog.Margin = new Padding(0);
            grpLog.Name = "grpLog";
            grpLog.Padding = new Padding(0);
            grpLog.Size = new Size(750, 485);
            grpLog.TabIndex = 0;
            grpLog.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(479, 78);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(141, 18);
            lblWelcome.TabIndex = 9;
            lblWelcome.Text = "Welcome Back!";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.ForeColor = SystemColors.HotTrack;
            lblSignUp.Location = new Point(496, 402);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(110, 18);
            lblSignUp.TabIndex = 8;
            lblSignUp.Text = "Sign up here";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(462, 378);
            label3.Name = "label3";
            label3.Size = new Size(184, 18);
            label3.TabIndex = 7;
            label3.Text = "Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(419, 323);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(273, 41);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(419, 278);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(419, 247);
            label2.Name = "label2";
            label2.Size = new Size(124, 18);
            label2.TabIndex = 4;
            label2.Text = "Enter Password";
            // 
            // txtStudentNum
            // 
            txtStudentNum.Location = new Point(419, 202);
            txtStudentNum.Name = "txtStudentNum";
            txtStudentNum.Size = new Size(273, 23);
            txtStudentNum.TabIndex = 3;
            txtStudentNum.TextChanged += txtStudentNum_TextChanged;
            // 
            // lbl_stud
            // 
            lbl_stud.AutoSize = true;
            lbl_stud.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_stud.Location = new Point(419, 171);
            lbl_stud.Name = "lbl_stud";
            lbl_stud.Size = new Size(130, 18);
            lbl_stud.TabIndex = 2;
            lbl_stud.Text = "Student Number";
            // 
            // pic1
            // 
            pic1.Image = Properties.Resources.lib;
            pic1.Location = new Point(0, 0);
            pic1.Name = "pic1";
            pic1.Size = new Size(375, 485);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1084, 561);
            Controls.Add(grpLog);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urban Read";
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            grpLog.ResumeLayout(false);
            grpLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLog;
        private Label lblSignUp;
        private Label label3;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        public TextBox txtStudentNum;
        private Label lbl_stud;
        private PictureBox pic1;
        private Label lblWelcome;
    }
}