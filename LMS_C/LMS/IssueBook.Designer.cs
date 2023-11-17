namespace LMS
{
    partial class frmIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBook));
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
            btnIssue = new Button();
            btnDeny = new Button();
            listView1 = new ListView();
            lvwUser_ID = new ColumnHeader();
            lvwbkID = new ColumnHeader();
            lvwName = new ColumnHeader();
            lvwTitle = new ColumnHeader();
            lvwDate = new ColumnHeader();
            checkedListBox1 = new CheckedListBox();
            lvwBorrowID = new ColumnHeader();
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
            lblDashboard.Click += lblDashboard_Click;
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
            label1.Font = new Font("Modern No. 20", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 34);
            label1.Name = "label1";
            label1.Size = new Size(207, 36);
            label1.TabIndex = 3;
            label1.Text = "Issue a Book";
            // 
            // btnIssue
            // 
            btnIssue.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssue.Location = new Point(525, 497);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(105, 39);
            btnIssue.TabIndex = 5;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnDeny
            // 
            btnDeny.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeny.Location = new Point(665, 497);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(105, 39);
            btnDeny.TabIndex = 6;
            btnDeny.Text = "Deny";
            btnDeny.UseVisualStyleBackColor = true;
            btnDeny.Click += btnDeny_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lvwBorrowID, lvwUser_ID, lvwbkID, lvwName, lvwTitle, lvwDate });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(237, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(835, 396);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // lvwUser_ID
            // 
            lvwUser_ID.Text = "User ID";
            lvwUser_ID.TextAlign = HorizontalAlignment.Center;
            // 
            // lvwbkID
            // 
            lvwbkID.Text = "Book ID";
            lvwbkID.TextAlign = HorizontalAlignment.Center;
            lvwbkID.Width = 80;
            // 
            // lvwName
            // 
            lvwName.Text = "Name";
            lvwName.TextAlign = HorizontalAlignment.Center;
            lvwName.Width = 200;
            // 
            // lvwTitle
            // 
            lvwTitle.Text = "Book ";
            lvwTitle.TextAlign = HorizontalAlignment.Center;
            lvwTitle.Width = 250;
            // 
            // lvwDate
            // 
            lvwDate.Text = "Borrow Date";
            lvwDate.TextAlign = HorizontalAlignment.Center;
            lvwDate.Width = 250;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(753, 16);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 8;
            // 
            // lvwBorrowID
            // 
            lvwBorrowID.Text = "Borrow ID";
            lvwBorrowID.Width = 100;
            // 
            // frmIssueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(1084, 561);
            Controls.Add(checkedListBox1);
            Controls.Add(listView1);
            Controls.Add(btnDeny);
            Controls.Add(btnIssue);
            Controls.Add(label1);
            Controls.Add(pnlSidebar);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmIssueBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Book";
            FormClosed += frmIssueBook_FormClosed;
            Load += frmIssueBook_Load;
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
        private Button btnIssue;
        private Button btnDeny;
        private ListView listView1;
        private ColumnHeader lvwbkID;
        private ColumnHeader lvwName;
        private ColumnHeader lvwTitle;
        private CheckedListBox checkedListBox1;
        private ColumnHeader lvwDate;
        private ColumnHeader lvwUser_ID;
        private ColumnHeader lvwBorrowID;
    }
}