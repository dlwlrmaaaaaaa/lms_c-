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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(603, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 32);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(489, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 32);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(375, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 32);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(261, 20);
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
            this.txtTitle.Location = new System.Drawing.Point(12, 76);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 23);
            this.txtTitle.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
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
            this.lvwBooks.Location = new System.Drawing.Point(261, 58);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(527, 390);
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
            this.txtSummary.Location = new System.Drawing.Point(12, 319);
            this.txtSummary.MaxLength = 16;
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(229, 129);
            this.txtSummary.TabIndex = 33;
            this.txtSummary.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Summary";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(12, 219);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(229, 23);
            this.txtISBN.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "ISBN";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(12, 171);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(229, 23);
            this.txtGenre.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Genre";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(12, 122);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(229, 23);
            this.txtAuthor.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Manage Books";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(12, 266);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(229, 23);
            this.txtCopies.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Copies";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(753, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(304, 152);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(45, 23);
            this.txtID.TabIndex = 46;
            this.txtID.Visible = false;
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageBooks_FormClosed);
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Label label1;
        private TextBox txtCopies;
        private Label label8;
        private ColumnHeader lvwSummary;
        private PictureBox pictureBox1;
        private TextBox txtID;
    }
}