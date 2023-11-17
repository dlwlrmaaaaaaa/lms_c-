using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace LMS
{
    partial class frmBorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowBook));
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
            btnCancel = new Button();
            btnAddBook = new Button();
            label6 = new Label();
            txtSummary = new TextBox();
            label5 = new Label();
            txtISBN = new TextBox();
            label4 = new Label();
            txtGenre = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            picBook = new PictureBox();
            label7 = new Label();
            txtCopies = new TextBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
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
            pnlSidebar.Location = new Point(-1, -2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(208, 563);
            pnlSidebar.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.ControlDarkDark;
            lblSearch.Location = new Point(64, 302);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(62, 18);
            lblSearch.TabIndex = 14;
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
            // btnCancel
            // 
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(627, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 57);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBook.Location = new Point(465, 472);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(130, 57);
            btnAddBook.TabIndex = 36;
            btnAddBook.Text = "Borrow Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(228, 42);
            label6.Name = "label6";
            label6.Size = new Size(231, 36);
            label6.TabIndex = 34;
            label6.Text = "Borrow Books";
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(585, 285);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.Size = new Size(454, 181);
            txtSummary.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(465, 285);
            label5.Name = "label5";
            label5.Size = new Size(91, 18);
            label5.TabIndex = 32;
            label5.Text = "Summary";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(585, 223);
            txtISBN.Name = "txtISBN";
            txtISBN.ReadOnly = true;
            txtISBN.Size = new Size(454, 23);
            txtISBN.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(465, 226);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 30;
            label4.Text = "ISBN";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(585, 183);
            txtGenre.Name = "txtGenre";
            txtGenre.ReadOnly = true;
            txtGenre.Size = new Size(454, 23);
            txtGenre.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(465, 186);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 28;
            label3.Text = "Genre";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(585, 146);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(454, 23);
            txtAuthor.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(465, 149);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 26;
            label2.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(585, 108);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(454, 23);
            txtTitle.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(465, 111);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 24;
            label1.Text = "Title";
            // 
            // picBook
            // 
            picBook.BackColor = Color.Azure;
            picBook.BorderStyle = BorderStyle.FixedSingle;
            picBook.Location = new Point(240, 108);
            picBook.Name = "picBook";
            picBook.Size = new Size(207, 275);
            picBook.TabIndex = 23;
            picBook.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(465, 258);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 38;
            label7.Text = "Copies";
            // 
            // txtCopies
            // 
            txtCopies.Enabled = false;
            txtCopies.Location = new Point(585, 256);
            txtCopies.Name = "txtCopies";
            txtCopies.ReadOnly = true;
            txtCopies.Size = new Size(454, 23);
            txtCopies.TabIndex = 39;
            // 
            // frmBorrowBook
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(1084, 561);
            Controls.Add(txtCopies);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnAddBook);
            Controls.Add(label6);
            Controls.Add(txtSummary);
            Controls.Add(label5);
            Controls.Add(txtISBN);
            Controls.Add(label4);
            Controls.Add(txtGenre);
            Controls.Add(label3);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(picBook);
            Controls.Add(pnlSidebar);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBorrowBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow Book";
            FormClosed += frmBorrowBook_FormClosed;
            Load += frmBorrowBook_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
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
        private Button btnAddBook;
        private Label label6;
        private TextBox txtSummary;
        private Label label5;
        private TextBox txtISBN;
        private Label label4;
        private TextBox txtGenre;
        private Label label3;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private PictureBox picBook;
        private Label lblSearch;
        private Label label7;
        private TextBox txtCopies;
    }
}