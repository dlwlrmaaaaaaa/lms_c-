namespace LMS
{
    partial class ManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.imgLogout = new System.Windows.Forms.PictureBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.imgBooks = new System.Windows.Forms.PictureBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.lvwID = new System.Windows.Forms.ColumnHeader();
            this.lvwTitle = new System.Windows.Forms.ColumnHeader();
            this.lvwAuthor = new System.Windows.Forms.ColumnHeader();
            this.lvwGenre = new System.Windows.Forms.ColumnHeader();
            this.lvwISBN = new System.Windows.Forms.ColumnHeader();
            this.lvwCopies = new System.Windows.Forms.ColumnHeader();
            this.lvwSummary = new System.Windows.Forms.ColumnHeader();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Azure;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblSearch);
            this.pnlSidebar.Controls.Add(this.imgSearch);
            this.pnlSidebar.Controls.Add(this.lblLogout);
            this.pnlSidebar.Controls.Add(this.imgLogout);
            this.pnlSidebar.Controls.Add(this.lblBooks);
            this.pnlSidebar.Controls.Add(this.imgBooks);
            this.pnlSidebar.Controls.Add(this.lblHome);
            this.pnlSidebar.Controls.Add(this.imgHome);
            this.pnlSidebar.Controls.Add(this.lblDashboard);
            this.pnlSidebar.Controls.Add(this.imgDashboard);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.imgLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(-1, -1);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(208, 563);
            this.pnlSidebar.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearch.Location = new System.Drawing.Point(64, 302);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 18);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search";
            // 
            // imgSearch
            // 
            this.imgSearch.Image = global::LMS.Properties.Resources.search;
            this.imgSearch.Location = new System.Drawing.Point(28, 296);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(30, 30);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSearch.TabIndex = 12;
            this.imgSearch.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogout.Location = new System.Drawing.Point(83, 512);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(64, 18);
            this.lblLogout.TabIndex = 11;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // imgLogout
            // 
            this.imgLogout.Image = global::LMS.Properties.Resources.logout;
            this.imgLogout.Location = new System.Drawing.Point(159, 506);
            this.imgLogout.Name = "imgLogout";
            this.imgLogout.Size = new System.Drawing.Size(30, 30);
            this.imgLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogout.TabIndex = 10;
            this.imgLogout.TabStop = false;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBooks.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBooks.Location = new System.Drawing.Point(64, 344);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(85, 18);
            this.lblBooks.TabIndex = 9;
            this.lblBooks.Text = "My Books";
            // 
            // imgBooks
            // 
            this.imgBooks.Image = global::LMS.Properties.Resources.books;
            this.imgBooks.Location = new System.Drawing.Point(28, 338);
            this.imgBooks.Name = "imgBooks";
            this.imgBooks.Size = new System.Drawing.Size(30, 30);
            this.imgBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBooks.TabIndex = 8;
            this.imgBooks.TabStop = false;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHome.Location = new System.Drawing.Point(63, 259);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(55, 18);
            this.lblHome.TabIndex = 5;
            this.lblHome.Text = "Home";
            // 
            // imgHome
            // 
            this.imgHome.Image = global::LMS.Properties.Resources.home;
            this.imgHome.Location = new System.Drawing.Point(27, 253);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(30, 30);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHome.TabIndex = 4;
            this.imgHome.TabStop = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.Location = new System.Drawing.Point(63, 215);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(95, 18);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // imgDashboard
            // 
            this.imgDashboard.Image = global::LMS.Properties.Resources.dashboard;
            this.imgDashboard.Location = new System.Drawing.Point(27, 208);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(30, 30);
            this.imgDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDashboard.TabIndex = 2;
            this.imgDashboard.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLogo.Location = new System.Drawing.Point(21, 95);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(168, 44);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "UrbanRead";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::LMS.Properties.Resources.liblogo1;
            this.imgLogo.Location = new System.Drawing.Point(63, 22);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(70, 70);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(883, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 32);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(769, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 32);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(655, 507);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 32);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(541, 507);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 32);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(245, 161);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 23);
            this.txtTitle.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Title";
            // 
            // lvwBooks
            // 
            this.lvwBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwID,
            this.lvwTitle,
            this.lvwAuthor,
            this.lvwGenre,
            this.lvwISBN,
            this.lvwCopies,
            this.lvwSummary});
            this.lvwBooks.FullRowSelect = true;
            this.lvwBooks.GridLines = true;
            this.lvwBooks.Location = new System.Drawing.Point(492, 94);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(564, 405);
            this.lvwBooks.TabIndex = 34;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.View = System.Windows.Forms.View.Details;
            this.lvwBooks.DoubleClick += new System.EventHandler(this.lvwBooks_DoubleClick);
            // 
            // lvwID
            // 
            this.lvwID.Text = "ID";
            this.lvwID.Width = 30;
            // 
            // lvwTitle
            // 
            this.lvwTitle.Text = "Title";
            this.lvwTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwTitle.Width = 200;
            // 
            // lvwAuthor
            // 
            this.lvwAuthor.Text = "Author";
            this.lvwAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwAuthor.Width = 180;
            // 
            // lvwGenre
            // 
            this.lvwGenre.Text = "Genre";
            this.lvwGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwGenre.Width = 75;
            // 
            // lvwISBN
            // 
            this.lvwISBN.Text = "ISBN";
            this.lvwISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwISBN.Width = 100;
            // 
            // lvwCopies
            // 
            this.lvwCopies.Text = "Copies";
            this.lvwCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwCopies.Width = 50;
            // 
            // lvwSummary
            // 
            this.lvwSummary.Text = "Summary";
            this.lvwSummary.Width = 200;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(245, 405);
            this.txtSummary.MaxLength = 16;
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(229, 134);
            this.txtSummary.TabIndex = 33;
            this.txtSummary.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Summary";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(245, 305);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(229, 23);
            this.txtISBN.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "ISBN";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(245, 257);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(229, 23);
            this.txtGenre.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Genre";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(245, 209);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(229, 23);
            this.txtAuthor.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Author";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(245, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 23);
            this.txtID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Manage Books";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(245, 352);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(229, 23);
            this.txtCopies.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Copies";
            // 
            // frmManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvwBooks);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageBooks_FormClosed);
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnEdit;
        private TextBox txtTitle;
        private Label label5;
        private ListView lvwBooks;
        private ColumnHeader lvwID;
        private ColumnHeader lvwTitle;
        private ColumnHeader lvwAuthor;
        private ColumnHeader lvwGenre;
        private ColumnHeader lvwISBN;
        private ColumnHeader lvwCopies;
        private TextBox txtSummary;
        private Label label6;
        private TextBox txtISBN;
        private Label label7;
        private TextBox txtGenre;
        private Label label4;
        private TextBox txtAuthor;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private TextBox txtCopies;
        private Label label8;
        private ColumnHeader lvwSummary;
    }
}