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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtxStudNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvwAccounts = new System.Windows.Forms.ListView();
            this.lvwID = new System.Windows.Forms.ColumnHeader();
            this.lvwStudentID = new System.Windows.Forms.ColumnHeader();
            this.lvwName = new System.Windows.Forms.ColumnHeader();
            this.lvwEmail = new System.Windows.Forms.ColumnHeader();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Users";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(299, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 23);
            this.txtID.TabIndex = 5;
            // 
            // txtxStudNo
            // 
            this.txtxStudNo.Location = new System.Drawing.Point(12, 145);
            this.txtxStudNo.Name = "txtxStudNo";
            this.txtxStudNo.Size = new System.Drawing.Size(229, 23);
            this.txtxStudNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 200);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 23);
            this.txtName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 318);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(229, 23);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email Address";
            // 
            // lvwAccounts
            // 
            this.lvwAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwID,
            this.lvwStudentID,
            this.lvwName,
            this.lvwEmail});
            this.lvwAccounts.FullRowSelect = true;
            this.lvwAccounts.GridLines = true;
            this.lvwAccounts.Location = new System.Drawing.Point(264, 64);
            this.lvwAccounts.Name = "lvwAccounts";
            this.lvwAccounts.Size = new System.Drawing.Size(524, 384);
            this.lvwAccounts.TabIndex = 14;
            this.lvwAccounts.UseCompatibleStateImageBehavior = false;
            this.lvwAccounts.View = System.Windows.Forms.View.Details;
            this.lvwAccounts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwAccounts_ItemSelectionChanged);
            this.lvwAccounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwAccounts_MouseDoubleClick);
            // 
            // lvwID
            // 
            this.lvwID.Text = "ID";
            this.lvwID.Width = 30;
            // 
            // lvwStudentID
            // 
            this.lvwStudentID.Text = "Student Number";
            this.lvwStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwStudentID.Width = 150;
            // 
            // lvwName
            // 
            this.lvwName.Text = "Name";
            this.lvwName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwName.Width = 180;
            // 
            // lvwEmail
            // 
            this.lvwEmail.Text = "Email";
            this.lvwEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwEmail.Width = 200;
            // 
            // txtAccType
            // 
            this.txtAccType.Enabled = false;
            this.txtAccType.Location = new System.Drawing.Point(12, 83);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.Size = new System.Drawing.Size(229, 23);
            this.txtAccType.TabIndex = 16;
            this.txtAccType.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Account Type";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 378);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 32);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 416);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 32);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(753, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvwAccounts);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtxStudNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}