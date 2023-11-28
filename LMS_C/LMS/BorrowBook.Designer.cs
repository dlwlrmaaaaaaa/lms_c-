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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(168, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 57);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(12, 365);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(150, 57);
            this.btnAddBook.TabIndex = 36;
            this.btnAddBook.Text = "Borrow Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Borrow Books";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(329, 246);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(459, 181);
            this.txtSummary.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(232, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Summary";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(329, 179);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(459, 23);
            this.txtISBN.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(232, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "ISBN";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(329, 139);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(459, 23);
            this.txtGenre.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(232, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Genre";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(329, 102);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(459, 23);
            this.txtAuthor.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(232, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(329, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(459, 23);
            this.txtTitle.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Title";
            // 
            // picBook
            // 
            this.picBook.BackColor = System.Drawing.Color.Azure;
            this.picBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBook.Location = new System.Drawing.Point(12, 64);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(207, 275);
            this.picBook.TabIndex = 23;
            this.picBook.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(232, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Enabled = false;
            this.txtCopies.Location = new System.Drawing.Point(329, 212);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.ReadOnly = true;
            this.txtCopies.Size = new System.Drawing.Size(459, 23);
            this.txtCopies.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(753, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBook);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.frmBorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Label label7;
        private TextBox txtCopies;
        private PictureBox pictureBox1;
    }
}