namespace LMS
{
    partial class frmMyBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyBooks));
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
            label7 = new Label();
            btnReturn = new Button();
            listView1 = new ListView();
            lvwBorrowID = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
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
            pnlSidebar.Size = new Size(234, 563);
            pnlSidebar.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.ControlDarkDark;
            lblSearch.Location = new Point(72, 302);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(62, 18);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search";
            lblSearch.Click += lblSearch_Click;
            // 
            // imgSearch
            // 
            imgSearch.Image = Properties.Resources.search;
            imgSearch.Location = new Point(32, 296);
            imgSearch.Name = "imgSearch";
            imgSearch.Size = new Size(34, 30);
            imgSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSearch.TabIndex = 12;
            imgSearch.TabStop = false;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogout.Location = new Point(93, 512);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(64, 18);
            lblLogout.TabIndex = 11;
            lblLogout.Text = "Logout";
            lblLogout.Click += lblLogout_Click;
            // 
            // imgLogout
            // 
            imgLogout.Image = Properties.Resources.logout;
            imgLogout.Location = new Point(179, 506);
            imgLogout.Name = "imgLogout";
            imgLogout.Size = new Size(34, 30);
            imgLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogout.TabIndex = 10;
            imgLogout.TabStop = false;
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBooks.ForeColor = SystemColors.ActiveCaptionText;
            lblBooks.Location = new Point(72, 344);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(85, 18);
            lblBooks.TabIndex = 9;
            lblBooks.Text = "My Books";
            // 
            // imgBooks
            // 
            imgBooks.Image = Properties.Resources.books;
            imgBooks.Location = new Point(32, 338);
            imgBooks.Name = "imgBooks";
            imgBooks.Size = new Size(34, 30);
            imgBooks.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBooks.TabIndex = 8;
            imgBooks.TabStop = false;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHome.ForeColor = SystemColors.ControlDarkDark;
            lblHome.Location = new Point(71, 259);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(55, 18);
            lblHome.TabIndex = 5;
            lblHome.Text = "Home";
            lblHome.Click += lblHome_Click;
            // 
            // imgHome
            // 
            imgHome.Image = Properties.Resources.home;
            imgHome.Location = new Point(30, 253);
            imgHome.Name = "imgHome";
            imgHome.Size = new Size(34, 30);
            imgHome.SizeMode = PictureBoxSizeMode.StretchImage;
            imgHome.TabIndex = 4;
            imgHome.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.ForeColor = SystemColors.ControlDarkDark;
            lblDashboard.Location = new Point(71, 215);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(95, 18);
            lblDashboard.TabIndex = 3;
            lblDashboard.Text = "Dashboard";
            // 
            // imgDashboard
            // 
            imgDashboard.Image = Properties.Resources.dashboard;
            imgDashboard.Location = new Point(30, 208);
            imgDashboard.Name = "imgDashboard";
            imgDashboard.Size = new Size(34, 30);
            imgDashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            imgDashboard.TabIndex = 2;
            imgDashboard.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Viner Hand ITC", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogo.Location = new Point(24, 95);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(168, 44);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "UrbanRead";
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.liblogo1;
            imgLogo.Location = new Point(71, 22);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(79, 70);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(269, 22);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 21;
            label7.Text = "My Books";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(618, 500);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(246, 49);
            btnReturn.TabIndex = 23;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lvwBorrowID, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(276, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(887, 434);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // lvwBorrowID
            // 
            lvwBorrowID.Text = "Borrow ID";
            lvwBorrowID.TextAlign = HorizontalAlignment.Center;
            lvwBorrowID.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Book ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Book Title";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Copies";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Borrow Date";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Due Date";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 200;
            // 
            // frmMyBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(1220, 561);
            Controls.Add(listView1);
            Controls.Add(btnReturn);
            Controls.Add(label7);
            Controls.Add(pnlSidebar);
            Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMyBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urban Read";
            FormClosed += frmMyBooks_FormClosed;
            Load += frmMyBooks_Load;
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
        private Label label7;
        private Button btnReturn;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader lvwBorrowID;
    }
}