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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.lvwID = new System.Windows.Forms.ColumnHeader();
            this.lvwTitle = new System.Windows.Forms.ColumnHeader();
            this.lvwAuthor = new System.Windows.Forms.ColumnHeader();
            this.lvwGenre = new System.Windows.Forms.ColumnHeader();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.imgLogout = new System.Windows.Forms.PictureBox();
            this.imgBooks = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Azure;
            this.txtSearch.Location = new System.Drawing.Point(314, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(558, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.Azure;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(86, 18);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(212, 24);
            this.cmbCategories.TabIndex = 8;
            this.cmbCategories.Text = "Categories";
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // ListView
            // 
            this.ListView.BackColor = System.Drawing.Color.Azure;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwID,
            this.lvwTitle,
            this.lvwAuthor,
            this.lvwGenre});
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.Location = new System.Drawing.Point(86, 61);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(786, 488);
            this.ListView.TabIndex = 9;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // lvwID
            // 
            this.lvwID.Text = "Book ID";
            this.lvwID.Width = 230;
            // 
            // lvwTitle
            // 
            this.lvwTitle.Text = "Book Title";
            this.lvwTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwTitle.Width = 200;
            // 
            // lvwAuthor
            // 
            this.lvwAuthor.Text = "Author";
            this.lvwAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwAuthor.Width = 200;
            // 
            // lvwGenre
            // 
            this.lvwGenre.Text = "Genre";
            this.lvwGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwGenre.Width = 200;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Azure;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.imgHome);
            this.pnlSidebar.Controls.Add(this.panel2);
            this.pnlSidebar.Controls.Add(this.imgLogout);
            this.pnlSidebar.Controls.Add(this.imgBooks);
            this.pnlSidebar.Controls.Add(this.imgLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(-5, -1);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(74, 563);
            this.pnlSidebar.TabIndex = 10;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            // 
            // imgHome
            // 
            this.imgHome.Image = global::LMS.Properties.Resources.home;
            this.imgHome.Location = new System.Drawing.Point(17, 141);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(40, 40);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHome.TabIndex = 4;
            this.imgHome.TabStop = false;
            this.imgHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.imgSearch);
            this.panel2.Location = new System.Drawing.Point(-1, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 60);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // imgSearch
            // 
            this.imgSearch.Image = global::LMS.Properties.Resources.search;
            this.imgSearch.Location = new System.Drawing.Point(18, 10);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(40, 40);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSearch.TabIndex = 12;
            this.imgSearch.TabStop = false;
            // 
            // imgLogout
            // 
            this.imgLogout.Image = global::LMS.Properties.Resources.logout;
            this.imgLogout.Location = new System.Drawing.Point(17, 510);
            this.imgLogout.Name = "imgLogout";
            this.imgLogout.Size = new System.Drawing.Size(40, 40);
            this.imgLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogout.TabIndex = 10;
            this.imgLogout.TabStop = false;
            this.imgLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // imgBooks
            // 
            this.imgBooks.Image = global::LMS.Properties.Resources.books;
            this.imgBooks.Location = new System.Drawing.Point(17, 281);
            this.imgBooks.Name = "imgBooks";
            this.imgBooks.Size = new System.Drawing.Size(40, 40);
            this.imgBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBooks.TabIndex = 8;
            this.imgBooks.TabStop = false;
            this.imgBooks.Click += new System.EventHandler(this.lblBooks_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::LMS.Properties.Resources.liblogo1;
            this.imgLogo.Location = new System.Drawing.Point(8, 9);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(60, 60);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSearch_FormClosed);
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSearch;
        private ComboBox cmbCategories;

        private ListView ListView;
        private ColumnHeader lvwTitle;
        private ColumnHeader lvwAuthor;
        private ColumnHeader lvwAutho;
        private ColumnHeader lvwGenre;
        private ColumnHeader lvwID;
        private Panel pnlSidebar;
        private Panel panel2;
        private PictureBox imgHome;
        private PictureBox imgSearch;
        private PictureBox imgLogout;
        private PictureBox imgBooks;
        private PictureBox imgLogo;
    }
}