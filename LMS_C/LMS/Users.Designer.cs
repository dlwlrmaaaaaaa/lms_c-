namespace LMS
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            pnlSidebar = new Panel();
            lblSearch = new Label();
            imgSearch = new PictureBox();
            lblLogout = new Label();
            imgLogout = new PictureBox();
            lblBooks = new Label();
            imgBooks = new PictureBox();
            lblHome = new Label();
            imgHome = new PictureBox();
            lblDashboard = new Label();
            imgDashboard = new PictureBox();
            lblLogo = new Label();
            imgLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtxStudNo = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            lvwAccounts = new ListView();
            lvwID = new ColumnHeader();
            lvwStudentID = new ColumnHeader();
            lvwName = new ColumnHeader();
            lvwEmail = new ColumnHeader();
            txtAccType = new TextBox();
            label5 = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Azure;
            pnlSidebar.BorderStyle = BorderStyle.FixedSingle;
            pnlSidebar.Controls.Add(lblSearch);
            pnlSidebar.Controls.Add(imgSearch);
            pnlSidebar.Controls.Add(lblLogout);
            pnlSidebar.Controls.Add(imgLogout);
            pnlSidebar.Controls.Add(lblBooks);
            pnlSidebar.Controls.Add(imgBooks);
            pnlSidebar.Controls.Add(lblHome);
            pnlSidebar.Controls.Add(imgHome);
            pnlSidebar.Controls.Add(lblDashboard);
            pnlSidebar.Controls.Add(imgDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(imgLogo);
            pnlSidebar.Location = new Point(-1, -1);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(208, 563);
            pnlSidebar.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.ControlDarkDark;
            lblSearch.Location = new Point(64, 302);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(62, 18);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search";
            // 
            // imgSearch
            // 
            imgSearch.Image = Properties.Resources.search;
            imgSearch.Location = new Point(28, 296);
            imgSearch.Name = "imgSearch";
            imgSearch.Size = new Size(30, 30);
            imgSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSearch.TabIndex = 12;
            imgSearch.TabStop = false;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogout.Location = new Point(83, 512);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(64, 18);
            lblLogout.TabIndex = 11;
            lblLogout.Text = "Logout";
            lblLogout.Click += lblLogout_Click;
            // 
            // imgLogout
            // 
            imgLogout.Image = Properties.Resources.logout;
            imgLogout.Location = new Point(159, 506);
            imgLogout.Name = "imgLogout";
            imgLogout.Size = new Size(30, 30);
            imgLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogout.TabIndex = 10;
            imgLogout.TabStop = false;
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBooks.ForeColor = SystemColors.ControlDarkDark;
            lblBooks.Location = new Point(64, 344);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(85, 18);
            lblBooks.TabIndex = 9;
            lblBooks.Text = "My Books";
            // 
            // imgBooks
            // 
            imgBooks.Image = Properties.Resources.books;
            imgBooks.Location = new Point(28, 338);
            imgBooks.Name = "imgBooks";
            imgBooks.Size = new Size(30, 30);
            imgBooks.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBooks.TabIndex = 8;
            imgBooks.TabStop = false;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHome.ForeColor = SystemColors.ControlDarkDark;
            lblHome.Location = new Point(63, 259);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(55, 18);
            lblHome.TabIndex = 5;
            lblHome.Text = "Home";
            // 
            // imgHome
            // 
            imgHome.Image = Properties.Resources.home;
            imgHome.Location = new Point(27, 253);
            imgHome.Name = "imgHome";
            imgHome.Size = new Size(30, 30);
            imgHome.SizeMode = PictureBoxSizeMode.StretchImage;
            imgHome.TabIndex = 4;
            imgHome.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(63, 215);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(95, 18);
            lblDashboard.TabIndex = 3;
            lblDashboard.Text = "Dashboard";
            // 
            // imgDashboard
            // 
            imgDashboard.Image = Properties.Resources.dashboard;
            imgDashboard.Location = new Point(27, 208);
            imgDashboard.Name = "imgDashboard";
            imgDashboard.Size = new Size(30, 30);
            imgDashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            imgDashboard.TabIndex = 2;
            imgDashboard.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Viner Hand ITC", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogo.Location = new Point(21, 95);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(168, 44);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "UrbanRead";
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.liblogo1;
            imgLogo.Location = new Point(63, 22);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(70, 70);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 40);
            label1.Name = "label1";
            label1.Size = new Size(208, 34);
            label1.TabIndex = 3;
            label1.Text = "Manage Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 97);
            label2.Name = "label2";
            label2.Size = new Size(26, 16);
            label2.TabIndex = 4;
            label2.Text = "ID.";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(251, 116);
            txtID.Name = "txtID";
            txtID.Size = new Size(229, 23);
            txtID.TabIndex = 5;
            // 
            // txtxStudNo
            // 
            txtxStudNo.Location = new Point(251, 241);
            txtxStudNo.Name = "txtxStudNo";
            txtxStudNo.Size = new Size(229, 23);
            txtxStudNo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 222);
            label3.Name = "label3";
            label3.Size = new Size(114, 16);
            label3.TabIndex = 6;
            label3.Text = "Student Number";
            // 
            // txtName
            // 
            txtName.Location = new Point(251, 296);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 277);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(251, 414);
            txtPassword.MaxLength = 16;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 393);
            label6.Name = "label6";
            label6.Size = new Size(69, 16);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 355);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 336);
            label7.Name = "label7";
            label7.Size = new Size(97, 16);
            label7.TabIndex = 10;
            label7.Text = "Email Address";
            // 
            // lvwAccounts
            // 
            lvwAccounts.Columns.AddRange(new ColumnHeader[] { lvwID, lvwStudentID, lvwName, lvwEmail });
            lvwAccounts.FullRowSelect = true;
            lvwAccounts.GridLines = true;
            lvwAccounts.Location = new Point(498, 95);
            lvwAccounts.Name = "lvwAccounts";
            lvwAccounts.Size = new Size(562, 435);
            lvwAccounts.TabIndex = 14;
            lvwAccounts.UseCompatibleStateImageBehavior = false;
            lvwAccounts.View = View.Details;
            lvwAccounts.ItemSelectionChanged += lvwAccounts_ItemSelectionChanged;
            lvwAccounts.MouseDoubleClick += lvwAccounts_MouseDoubleClick;
            // 
            // lvwID
            // 
            lvwID.Text = "ID";
            lvwID.Width = 30;
            // 
            // lvwStudentID
            // 
            lvwStudentID.Text = "Student Number";
            lvwStudentID.TextAlign = HorizontalAlignment.Center;
            lvwStudentID.Width = 150;
            // 
            // lvwName
            // 
            lvwName.Text = "Name";
            lvwName.TextAlign = HorizontalAlignment.Center;
            lvwName.Width = 180;
            // 
            // lvwEmail
            // 
            lvwEmail.Text = "Email";
            lvwEmail.TextAlign = HorizontalAlignment.Center;
            lvwEmail.Width = 200;
            // 
            // txtAccType
            // 
            txtAccType.Enabled = false;
            txtAccType.Location = new Point(251, 177);
            txtAccType.Name = "txtAccType";
            txtAccType.Size = new Size(229, 23);
            txtAccType.TabIndex = 16;
            txtAccType.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 158);
            label5.Name = "label5";
            label5.Size = new Size(99, 16);
            label5.TabIndex = 15;
            label5.Text = "Account Type";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(251, 458);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 32);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(332, 458);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(413, 458);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(413, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 32);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(332, 498);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(251, 498);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 32);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(1084, 561);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(txtAccType);
            Controls.Add(label5);
            Controls.Add(lvwAccounts);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtxStudNo);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlSidebar);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            FormClosed += frmUsers_FormClosed;
            Load += frmUsers_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblSearch;
        private PictureBox imgSearch;
        private Label lblLogout;
        private PictureBox imgLogout;
        private Label lblBooks;
        private PictureBox imgBooks;
        private Label lblHome;
        private PictureBox imgHome;
        private Label lblDashboard;
        private PictureBox imgDashboard;
        private Label lblLogo;
        private PictureBox imgLogo;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtxStudNo;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private ListView lvwAccounts;
        private TextBox txtAccType;
        private Label label5;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnNew;
        private ColumnHeader lvwID;
        private ColumnHeader lvwStudentID;
        private ColumnHeader lvwName;
        private ColumnHeader lvwEmail;
    }
}