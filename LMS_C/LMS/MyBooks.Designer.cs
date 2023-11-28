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
            this.label7 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvwBorrowID = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgBooks = new System.Windows.Forms.PictureBox();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.imgLogout = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnLost = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(75, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "My Books";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(272, 506);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 45);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwBorrowID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(82, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(790, 434);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // lvwBorrowID
            // 
            this.lvwBorrowID.Text = "Borrow ID";
            this.lvwBorrowID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwBorrowID.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Book Title";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Copies";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Borrow Date";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Due Date";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Azure;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.imgHome);
            this.pnlSidebar.Controls.Add(this.panel2);
            this.pnlSidebar.Controls.Add(this.imgSearch);
            this.pnlSidebar.Controls.Add(this.imgLogout);
            this.pnlSidebar.Controls.Add(this.imgLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(-5, -1);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(74, 563);
            this.pnlSidebar.TabIndex = 25;
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
            this.panel2.Controls.Add(this.imgBooks);
            this.panel2.Location = new System.Drawing.Point(-1, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 60);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // imgBooks
            // 
            this.imgBooks.Image = global::LMS.Properties.Resources.books;
            this.imgBooks.Location = new System.Drawing.Point(18, 10);
            this.imgBooks.Name = "imgBooks";
            this.imgBooks.Size = new System.Drawing.Size(40, 40);
            this.imgBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBooks.TabIndex = 8;
            this.imgBooks.TabStop = false;
            // 
            // imgSearch
            // 
            this.imgSearch.Image = global::LMS.Properties.Resources.search;
            this.imgSearch.Location = new System.Drawing.Point(17, 208);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(40, 40);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSearch.TabIndex = 12;
            this.imgSearch.TabStop = false;
            this.imgSearch.Click += new System.EventHandler(this.lblSearch_Click);
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
            // btnLost
            // 
            this.btnLost.Location = new System.Drawing.Point(485, 505);
            this.btnLost.Name = "btnLost";
            this.btnLost.Size = new System.Drawing.Size(200, 45);
            this.btnLost.TabIndex = 26;
            this.btnLost.Text = "Lost Book";
            this.btnLost.UseVisualStyleBackColor = true;
            this.btnLost.Click += new System.EventHandler(this.btnLost_Click);
            // 
            // frmMyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnLost);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMyBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Read";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMyBooks_FormClosed);
            this.Load += new System.EventHandler(this.frmMyBooks_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private Button btnReturn;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader lvwBorrowID;
        private Panel pnlSidebar;
        private Panel panel2;
        private PictureBox imgHome;
        private PictureBox imgSearch;
        private PictureBox imgLogout;
        private PictureBox imgBooks;
        private PictureBox imgLogo;
        private Button btnLost;
    }
}