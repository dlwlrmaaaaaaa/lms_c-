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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvwBorrowID = new System.Windows.Forms.ColumnHeader();
            this.lvwUser_ID = new System.Windows.Forms.ColumnHeader();
            this.lvwbkID = new System.Windows.Forms.ColumnHeader();
            this.lvwName = new System.Windows.Forms.ColumnHeader();
            this.lvwTitle = new System.Windows.Forms.ColumnHeader();
            this.lvwDate = new System.Windows.Forms.ColumnHeader();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Issue a Book";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwBorrowID,
            this.lvwUser_ID,
            this.lvwbkID,
            this.lvwName,
            this.lvwTitle,
            this.lvwDate});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 385);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_MouseDoubleClick);
            // 
            // lvwBorrowID
            // 
            this.lvwBorrowID.Text = "Borrow ID";
            this.lvwBorrowID.Width = 100;
            // 
            // lvwUser_ID
            // 
            this.lvwUser_ID.Text = "User ID";
            this.lvwUser_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvwbkID
            // 
            this.lvwbkID.Text = "Book ID";
            this.lvwbkID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwbkID.Width = 80;
            // 
            // lvwName
            // 
            this.lvwName.Text = "Name";
            this.lvwName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwName.Width = 200;
            // 
            // lvwTitle
            // 
            this.lvwTitle.Text = "Book ";
            this.lvwTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwTitle.Width = 250;
            // 
            // lvwDate
            // 
            this.lvwDate.Text = "Borrow Date";
            this.lvwDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvwDate.Width = 250;
            // 
            // btnDeny
            // 
            this.btnDeny.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeny.Location = new System.Drawing.Point(629, 15);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(100, 32);
            this.btnDeny.TabIndex = 9;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIssue.Location = new System.Drawing.Point(523, 15);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(100, 32);
            this.btnIssue.TabIndex = 8;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(753, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.frmIssueBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private ListView listView1;
        private ColumnHeader lvwbkID;
        private ColumnHeader lvwName;
        private ColumnHeader lvwTitle;
        private ColumnHeader lvwDate;
        private ColumnHeader lvwUser_ID;
        private ColumnHeader lvwBorrowID;
        private Button btnDeny;
        private Button btnIssue;
        private PictureBox pictureBox1;
    }
}