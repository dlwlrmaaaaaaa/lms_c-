namespace LMS
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            pnlSidebar = new Panel();
            lblLogout = new Label();
            imgLogout = new PictureBox();
            lblBooks = new Label();
            imgBooks = new PictureBox();
            lblSearch = new Label();
            imgSearch = new PictureBox();
            lblHome = new Label();
            imgHome = new PictureBox();
            lblDashboard = new Label();
            imgDashboard = new PictureBox();
            lblLogo = new Label();
            imgLogo = new PictureBox();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            cmbCategories = new ComboBox();
            ListView = new ListView();
            lvwID = new ColumnHeader();
            lvwTitle = new ColumnHeader();
            lvwAuthor = new ColumnHeader();
            lvwGenre = new ColumnHeader();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Azure;
            pnlSidebar.BorderStyle = BorderStyle.FixedSingle;
            pnlSidebar.Controls.Add(lblLogout);
            pnlSidebar.Controls.Add(imgLogout);
            pnlSidebar.Controls.Add(lblBooks);
            pnlSidebar.Controls.Add(imgBooks);
            pnlSidebar.Controls.Add(lblSearch);
            pnlSidebar.Controls.Add(imgSearch);
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
            lblBooks.Click += lblBooks_Click;
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
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(64, 302);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(62, 18);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Search";
            // 
            // imgSearch
            // 
            imgSearch.Image = Properties.Resources.search;
            imgSearch.Location = new Point(28, 296);
            imgSearch.Name = "imgSearch";
            imgSearch.Size = new Size(30, 30);
            imgSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSearch.TabIndex = 6;
            imgSearch.TabStop = false;
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
            lblHome.Click += lblHome_Click;
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
            lblDashboard.ForeColor = SystemColors.ControlDarkDark;
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
            // txtSearch
            // 
            txtSearch.BackColor = Color.Azure;
            txtSearch.Location = new Point(454, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(575, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // cmbCategories
            // 
            cmbCategories.BackColor = Color.Azure;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(226, 22);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(212, 24);
            cmbCategories.TabIndex = 8;
            cmbCategories.Text = "Categories";
            // 
            // ListView
            // 
            ListView.BackColor = Color.Azure;
            ListView.Columns.AddRange(new ColumnHeader[] { lvwID, lvwTitle, lvwAuthor, lvwGenre });
            ListView.FullRowSelect = true;
            ListView.GridLines = true;
            ListView.Location = new Point(226, 65);
            ListView.Name = "ListView";
            ListView.Size = new Size(833, 471);
            ListView.TabIndex = 9;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            ListView.MouseDoubleClick += ListView_MouseDoubleClick;
            // 
            // lvwID
            // 
            lvwID.Text = "Book ID";
            lvwID.Width = 230;
            // 
            // lvwTitle
            // 
            lvwTitle.Text = "Book Title";
            lvwTitle.TextAlign = HorizontalAlignment.Center;
            lvwTitle.Width = 200;
            // 
            // lvwAuthor
            // 
            lvwAuthor.Text = "Author";
            lvwAuthor.TextAlign = HorizontalAlignment.Center;
            lvwAuthor.Width = 200;
            // 
            // lvwGenre
            // 
            lvwGenre.Text = "Genre";
            lvwGenre.TextAlign = HorizontalAlignment.Center;
            lvwGenre.Width = 200;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Azure;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.Location = new Point(268, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(761, 448);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Book Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Author";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Genre";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ISBN";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 160;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(1084, 561);
            Controls.Add(ListView);
            Controls.Add(listView1);
            Controls.Add(cmbCategories);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(pnlSidebar);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            FormClosed += frmSearch_FormClosed;
            Load += frmSearch_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblLogout;
        private PictureBox imgLogout;
        private Label lblBooks;
        private PictureBox imgBooks;
        private Label lblSearch;
        private PictureBox imgSearch;
        private Label lblHome;
        private PictureBox imgHome;
        private Label lblDashboard;
        private PictureBox imgDashboard;
        private Label lblLogo;
        private PictureBox imgLogo;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private ComboBox cmbCategories;

        private ListView ListView;
        private ColumnHeader lvwTitle;
        private ColumnHeader lvwAuthor;
        private ColumnHeader lvwAutho;
        private ColumnHeader lvwGenre;

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader lvwID;
    }
}