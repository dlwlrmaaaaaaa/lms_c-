namespace LMS
{
    partial class frmExpiredLoans
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
            this.lvwList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.btnPenalty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwList
            // 
            this.lvwList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.lvwList.FullRowSelect = true;
            this.lvwList.GridLines = true;
            this.lvwList.Location = new System.Drawing.Point(12, 64);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(776, 385);
            this.lvwList.TabIndex = 13;
            this.lvwList.UseCompatibleStateImageBehavior = false;
            this.lvwList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student No.";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Book Borrowed";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Due Date";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Days Overdue";
            this.columnHeader4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Expired Loans";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(753, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBlacklist.Location = new System.Drawing.Point(629, 15);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(100, 32);
            this.btnBlacklist.TabIndex = 17;
            this.btnBlacklist.Text = "Blacklist";
            this.btnBlacklist.UseVisualStyleBackColor = true;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // btnPenalty
            // 
            this.btnPenalty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPenalty.Location = new System.Drawing.Point(523, 15);
            this.btnPenalty.Name = "btnPenalty";
            this.btnPenalty.Size = new System.Drawing.Size(100, 32);
            this.btnPenalty.TabIndex = 16;
            this.btnPenalty.Text = "Penalty";
            this.btnPenalty.UseVisualStyleBackColor = true;
            this.btnPenalty.Click += new System.EventHandler(this.btnPenalty_Click);
            // 
            // frmExpiredLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnBlacklist);
            this.Controls.Add(this.btnPenalty);
            this.Controls.Add(this.lvwList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpiredLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiredLoans";
            this.Load += new System.EventHandler(this.frmExpiredLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvwList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader4;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnBlacklist;
        private Button btnPenalty;
    }
}