namespace LMS
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.grpSignUp = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.grpSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSignUp
            // 
            this.grpSignUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpSignUp.Controls.Add(this.txtType);
            this.grpSignUp.Controls.Add(this.txtEmailAdd);
            this.grpSignUp.Controls.Add(this.label6);
            this.grpSignUp.Controls.Add(this.txtFullName);
            this.grpSignUp.Controls.Add(this.label5);
            this.grpSignUp.Controls.Add(this.txtConfirmPass);
            this.grpSignUp.Controls.Add(this.label4);
            this.grpSignUp.Controls.Add(this.lblCreate);
            this.grpSignUp.Controls.Add(this.lblLogIn);
            this.grpSignUp.Controls.Add(this.label3);
            this.grpSignUp.Controls.Add(this.btnSignup);
            this.grpSignUp.Controls.Add(this.txtPassword);
            this.grpSignUp.Controls.Add(this.label2);
            this.grpSignUp.Controls.Add(this.txtStudentNum);
            this.grpSignUp.Controls.Add(this.label1);
            this.grpSignUp.Controls.Add(this.pic1);
            this.grpSignUp.Location = new System.Drawing.Point(167, 38);
            this.grpSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.grpSignUp.Name = "grpSignUp";
            this.grpSignUp.Padding = new System.Windows.Forms.Padding(0);
            this.grpSignUp.Size = new System.Drawing.Size(750, 485);
            this.grpSignUp.TabIndex = 1;
            this.grpSignUp.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(647, 462);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 23);
            this.txtType.TabIndex = 16;
            this.txtType.Text = "user";
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtType.Visible = false;
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(422, 210);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(273, 23);
            this.txtEmailAdd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(422, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "College Email Address";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(422, 153);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(273, 23);
            this.txtFullName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(422, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Full Name";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(422, 333);
            this.txtConfirmPass.MaxLength = 16;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(273, 23);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(422, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.Location = new System.Drawing.Point(473, 26);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(170, 18);
            this.lblCreate.TabIndex = 9;
            this.lblCreate.Text = "Create an Account";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogIn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLogIn.Location = new System.Drawing.Point(510, 458);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(99, 18);
            this.lblLogIn.TabIndex = 7;
            this.lblLogIn.Text = "Log in here";
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(459, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Already have an account?";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSignup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignup.Location = new System.Drawing.Point(425, 377);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(273, 41);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(422, 273);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(273, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(422, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Password";
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.Location = new System.Drawing.Point(422, 94);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(273, 23);
            this.txtStudentNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(422, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Number";
            // 
            // pic1
            // 
            this.pic1.Image = global::LMS.Properties.Resources.lib;
            this.pic1.Location = new System.Drawing.Point(0, 0);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(375, 485);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.grpSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Read";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSignUp_FormClosed);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.grpSignUp.ResumeLayout(false);
            this.grpSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpSignUp;
        private Label lblCreate;
        private Label lblLogIn;
        private Label label3;
        private Button btnSignup;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtStudentNum;
        private Label label1;
        private PictureBox pic1;
        private TextBox txtEmailAdd;
        private Label label6;
        private TextBox txtFullName;
        private Label label5;
        private TextBox txtConfirmPass;
        private Label label4;
        private TextBox txtType;
    }
}