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
            label1 = new Label();
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
            pictureBox1 = new PictureBox();
            columnHeader1 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(179, 29);
            label1.TabIndex = 3;
            label1.Text = "Manage Users";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(299, 110);
            txtID.Name = "txtID";
            txtID.Size = new Size(229, 23);
            txtID.TabIndex = 5;
            // 
            // txtxStudNo
            // 
            txtxStudNo.Location = new Point(12, 145);
            txtxStudNo.Name = "txtxStudNo";
            txtxStudNo.Size = new Size(229, 23);
            txtxStudNo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(114, 16);
            label3.TabIndex = 6;
            label3.Text = "Student Number";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 200);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 318);
            txtPassword.MaxLength = 16;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 297);
            label6.Name = "label6";
            label6.Size = new Size(69, 16);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 259);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 240);
            label7.Name = "label7";
            label7.Size = new Size(97, 16);
            label7.TabIndex = 10;
            label7.Text = "Email Address";
            // 
            // lvwAccounts
            // 
            lvwAccounts.Columns.AddRange(new ColumnHeader[] { lvwID, lvwStudentID, lvwName, lvwEmail, columnHeader1 });
            lvwAccounts.FullRowSelect = true;
            lvwAccounts.GridLines = true;
            lvwAccounts.Location = new Point(264, 64);
            lvwAccounts.Name = "lvwAccounts";
            lvwAccounts.Size = new Size(524, 384);
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
            txtAccType.Location = new Point(12, 83);
            txtAccType.Name = "txtAccType";
            txtAccType.Size = new Size(229, 23);
            txtAccType.TabIndex = 16;
            txtAccType.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 64);
            label5.Name = "label5";
            label5.Size = new Size(99, 16);
            label5.TabIndex = 15;
            label5.Text = "Account Type";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 378);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 32);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(174, 378);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(174, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 32);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 416);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 32);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x;
            pictureBox1.Location = new Point(753, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Status";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 100;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(800, 460);
            Controls.Add(pictureBox1);
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
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
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
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader1;
    }
}