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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.lbl_stud = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::LMS.Properties.Resources.lib;
            this.pic1.Location = new System.Drawing.Point(0, 0);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(412, 564);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 10;
            this.pic1.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblWelcome);
            this.pnlSidebar.Controls.Add(this.btnLogin);
            this.pnlSidebar.Controls.Add(this.txtPassword);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.txtStudentNum);
            this.pnlSidebar.Controls.Add(this.lbl_stud);
            this.pnlSidebar.Location = new System.Drawing.Point(467, 120);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(350, 339);
            this.pnlSidebar.TabIndex = 26;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(91, 57);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(141, 18);
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "Welcome Back!";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(34, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(273, 41);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(34, 221);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(273, 23);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Password";
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(34, 145);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(273, 23);
            this.txtStudentNum.TabIndex = 11;
            this.txtStudentNum.TextChanged += new System.EventHandler(this.txtStudentNum_TextChanged);
            // 
            // lbl_stud
            // 
            this.lbl_stud.AutoSize = true;
            this.lbl_stud.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_stud.Location = new System.Drawing.Point(34, 114);
            this.lbl_stud.Name = "lbl_stud";
            this.lbl_stud.Size = new System.Drawing.Size(130, 18);
            this.lbl_stud.TabIndex = 10;
            this.lbl_stud.Text = "Student Number";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pic1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Read";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pic1;
        private Panel pnlSidebar;
        private Label lblWelcome;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        public TextBox txtStudentNum;
        private Label lbl_stud;
    }
}