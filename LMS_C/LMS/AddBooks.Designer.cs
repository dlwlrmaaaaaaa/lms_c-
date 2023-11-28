namespace LMS
{
    partial class frmAddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBooks));
            this.picBook = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBook
            // 
            this.picBook.BackColor = System.Drawing.Color.Azure;
            this.picBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBook.Location = new System.Drawing.Point(12, 64);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(207, 275);
            this.picBook.TabIndex = 3;
            this.picBook.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(334, 61);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(454, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(334, 99);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(454, 23);
            this.txtAuthor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(236, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(334, 136);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(454, 23);
            this.txtGenre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(236, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(334, 176);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(454, 23);
            this.txtISBN.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(236, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Summary";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(334, 242);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(454, 206);
            this.txtSummary.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Add Books";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(89, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 41);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(173, 357);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(155, 41);
            this.btnAddBook.TabIndex = 21;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPhoto.Location = new System.Drawing.Point(12, 357);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(155, 41);
            this.btnPhoto.TabIndex = 20;
            this.btnPhoto.Text = "Choose a Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(236, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "ISBN";
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopies.Location = new System.Drawing.Point(236, 215);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(66, 18);
            this.lblCopies.TabIndex = 23;
            this.lblCopies.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(334, 210);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(454, 23);
            this.txtCopies.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(753, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnPhoto);
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
            this.MaximizeBox = false;
            this.Name = "frmAddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Books";
            this.Load += new System.EventHandler(this.frmAddBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox picBook;
        private Label label1;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtGenre;
        private Label label3;
        private TextBox txtISBN;
        private Label label5;
        private TextBox txtSummary;
        private Label label6;
        private Button btnCancel;
        private Button btnAddBook;
        private Button btnPhoto;
        private Label label4;
        private Label lblCopies;
        private TextBox txtCopies;
        private PictureBox pictureBox1;
    }
}