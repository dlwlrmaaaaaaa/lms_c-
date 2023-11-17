namespace LMS.Resources
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
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
            pnlActiveLoans = new Panel();
            lblActiveLoans = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pnlAddBooks = new Panel();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            pnlIssueBooks = new Panel();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            lvwList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pnlUsers = new Panel();
            lblActiveUsers = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblAdminName = new Label();
            panel3 = new Panel();
            lblExpiredLoans = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pnlManage = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            pnlActiveLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlAddBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlIssueBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            pnlSidebar.TabIndex = 1;
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
            lblSearch.Click += lblSearch_Click;
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
            // pnlActiveLoans
            // 
            pnlActiveLoans.BackColor = Color.LightSteelBlue;
            pnlActiveLoans.BorderStyle = BorderStyle.FixedSingle;
            pnlActiveLoans.Controls.Add(lblActiveLoans);
            pnlActiveLoans.Controls.Add(label2);
            pnlActiveLoans.Controls.Add(pictureBox2);
            pnlActiveLoans.Location = new Point(407, 22);
            pnlActiveLoans.Name = "pnlActiveLoans";
            pnlActiveLoans.Size = new Size(174, 120);
            pnlActiveLoans.TabIndex = 4;
            // 
            // lblActiveLoans
            // 
            lblActiveLoans.AutoSize = true;
            lblActiveLoans.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblActiveLoans.Location = new Point(27, 28);
            lblActiveLoans.Name = "lblActiveLoans";
            lblActiveLoans.Size = new Size(39, 42);
            lblActiveLoans.TabIndex = 4;
            lblActiveLoans.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 81);
            label2.Name = "label2";
            label2.Size = new Size(92, 16);
            label2.TabIndex = 3;
            label2.Text = "Active Loans";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(95, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pnlAddBooks
            // 
            pnlAddBooks.BackColor = Color.WhiteSmoke;
            pnlAddBooks.BorderStyle = BorderStyle.FixedSingle;
            pnlAddBooks.Controls.Add(label5);
            pnlAddBooks.Controls.Add(pictureBox5);
            pnlAddBooks.Location = new Point(975, 22);
            pnlAddBooks.Name = "pnlAddBooks";
            pnlAddBooks.Size = new Size(98, 120);
            pnlAddBooks.TabIndex = 7;
            pnlAddBooks.Click += pnlAddBooks_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 91);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 2;
            label5.Text = "Add Books";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 22);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 55);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pnlIssueBooks
            // 
            pnlIssueBooks.BackColor = Color.WhiteSmoke;
            pnlIssueBooks.BorderStyle = BorderStyle.FixedSingle;
            pnlIssueBooks.Controls.Add(label6);
            pnlIssueBooks.Controls.Add(pictureBox7);
            pnlIssueBooks.Location = new Point(767, 22);
            pnlIssueBooks.Name = "pnlIssueBooks";
            pnlIssueBooks.Size = new Size(98, 120);
            pnlIssueBooks.TabIndex = 7;
            pnlIssueBooks.Click += pnlIssueBooks_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 90);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 2;
            label6.Text = "Issue Books";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(16, 22);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(55, 55);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // lvwList
            // 
            lvwList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader6, columnHeader4, columnHeader5 });
            lvwList.FullRowSelect = true;
            lvwList.GridLines = true;
            lvwList.Location = new Point(227, 199);
            lvwList.Name = "lvwList";
            lvwList.Size = new Size(845, 344);
            lvwList.TabIndex = 8;
            lvwList.UseCompatibleStateImageBehavior = false;
            lvwList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student No.";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Book Borrowed";
            columnHeader3.Width = 300;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Copies";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date Borrowed";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Due Date";
            columnHeader5.Width = 120;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(227, 165);
            label7.Name = "label7";
            label7.Size = new Size(174, 25);
            label7.TabIndex = 9;
            label7.Text = "Welcome back ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(828, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.FromArgb(192, 255, 192);
            pnlUsers.BorderStyle = BorderStyle.FixedSingle;
            pnlUsers.Controls.Add(lblActiveUsers);
            pnlUsers.Controls.Add(label1);
            pnlUsers.Controls.Add(pictureBox1);
            pnlUsers.Location = new Point(227, 22);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(174, 120);
            pnlUsers.TabIndex = 11;
            pnlUsers.Click += pnlUsers_Click;
            // 
            // lblActiveUsers
            // 
            lblActiveUsers.AutoSize = true;
            lblActiveUsers.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblActiveUsers.Location = new Point(26, 28);
            lblActiveUsers.Name = "lblActiveUsers";
            lblActiveUsers.Size = new Size(39, 42);
            lblActiveUsers.TabIndex = 3;
            lblActiveUsers.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 81);
            label1.Name = "label1";
            label1.Size = new Size(90, 16);
            label1.TabIndex = 2;
            label1.Text = "Active Users";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminName.Location = new Point(390, 165);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(77, 25);
            lblAdminName.TabIndex = 12;
            lblAdminName.Text = "label4";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblExpiredLoans);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(587, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 120);
            panel3.TabIndex = 13;
            // 
            // lblExpiredLoans
            // 
            lblExpiredLoans.AutoSize = true;
            lblExpiredLoans.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpiredLoans.Location = new Point(33, 28);
            lblExpiredLoans.Name = "lblExpiredLoans";
            lblExpiredLoans.Size = new Size(39, 42);
            lblExpiredLoans.TabIndex = 4;
            lblExpiredLoans.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
            label3.TabIndex = 3;
            label3.Text = "Expired Loans";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(99, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pnlManage
            // 
            pnlManage.BackColor = Color.WhiteSmoke;
            pnlManage.BorderStyle = BorderStyle.FixedSingle;
            pnlManage.Controls.Add(label4);
            pnlManage.Controls.Add(pictureBox4);
            pnlManage.Location = new Point(871, 22);
            pnlManage.Name = "pnlManage";
            pnlManage.Size = new Size(98, 120);
            pnlManage.TabIndex = 14;
            pnlManage.Click += pnlManage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 85);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 2;
            label4.Text = "Manage \r\nBooks";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.books;
            pictureBox4.Location = new Point(19, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(1084, 561);
            Controls.Add(pnlManage);
            Controls.Add(panel3);
            Controls.Add(lblAdminName);
            Controls.Add(pnlUsers);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(lvwList);
            Controls.Add(pnlIssueBooks);
            Controls.Add(pnlAddBooks);
            Controls.Add(pnlActiveLoans);
            Controls.Add(pnlSidebar);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urban Read";
            FormClosed += frmDashboard_FormClosed;
            Load += Dashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            pnlActiveLoans.ResumeLayout(false);
            pnlActiveLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlAddBooks.ResumeLayout(false);
            pnlAddBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlIssueBooks.ResumeLayout(false);
            pnlIssueBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            pnlUsers.ResumeLayout(false);
            pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlManage.ResumeLayout(false);
            pnlManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private PictureBox imgLogo;
        private Label lblLogo;
        private Label lblLogout;
        private PictureBox imgLogout;
        private Label lblBooks;
        private PictureBox imgBooks;
        private Label lblHome;
        private PictureBox imgHome;
        private Label lblDashboard;
        private PictureBox imgDashboard;
        private Panel pnlActiveLoans;
        private Label label2;
        private PictureBox pictureBox2;
        private Label lblActiveLoans;
        private Panel pnlAddBooks;
        private Label label5;
        private PictureBox pictureBox5;
        private Panel pnlIssueBooks;
        private Label label6;
        private PictureBox pictureBox7;
        private ListView lvwList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label lblSearch;
        private PictureBox imgSearch;
        private Panel pnlUsers;
        private Label lblActiveUsers;
        private Label label1;
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label lblAdminName;
        private Panel panel3;
        private Label lblExpiredLoans;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel pnlManage;
        private Label label4;
        private PictureBox pictureBox4;
    }
}