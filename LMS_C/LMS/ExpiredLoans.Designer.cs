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
            lvwList = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnBlacklist = new Button();
            btnPenalty = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lvwList
            // 
            lvwList.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader1, columnHeader2, columnHeader3, columnHeader9, columnHeader5, columnHeader4, columnHeader6, columnHeader8 });
            lvwList.FullRowSelect = true;
            lvwList.GridLines = true;
            lvwList.Location = new Point(12, 64);
            lvwList.Name = "lvwList";
            lvwList.Size = new Size(776, 385);
            lvwList.TabIndex = 13;
            lvwList.UseCompatibleStateImageBehavior = false;
            lvwList.View = View.Details;
            lvwList.SelectedIndexChanged += lvwList_SelectedIndexChanged;
            lvwList.MouseDoubleClick += lvwList_MouseDoubleClick;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "User ID";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student No.";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Book Borrowed";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 300;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Due Date";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Days Overdue";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Penalty Applied";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Penalty Return Date ";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Penalty Count";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(190, 29);
            label1.TabIndex = 15;
            label1.Text = "Expired Loans";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.x;
            pictureBox1.Location = new Point(753, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBlacklist
            // 
            btnBlacklist.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBlacklist.Location = new Point(629, 15);
            btnBlacklist.Name = "btnBlacklist";
            btnBlacklist.Size = new Size(100, 32);
            btnBlacklist.TabIndex = 17;
            btnBlacklist.Text = "Blacklist";
            btnBlacklist.UseVisualStyleBackColor = true;
            btnBlacklist.Click += btnBlacklist_Click;
            // 
            // btnPenalty
            // 
            btnPenalty.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPenalty.Location = new Point(523, 15);
            btnPenalty.Name = "btnPenalty";
            btnPenalty.Size = new Size(100, 32);
            btnPenalty.TabIndex = 16;
            btnPenalty.Text = "Penalty";
            btnPenalty.UseVisualStyleBackColor = true;
            btnPenalty.Click += btnPenalty_Click;
            // 
            // frmExpiredLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 229, 255);
            ClientSize = new Size(800, 460);
            Controls.Add(btnBlacklist);
            Controls.Add(btnPenalty);
            Controls.Add(lvwList);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExpiredLoans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpiredLoans";
            Load += frmExpiredLoans_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}