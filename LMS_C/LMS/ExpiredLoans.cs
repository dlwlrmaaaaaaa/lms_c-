using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmExpiredLoans : Form
    {
        private int admin_id;
        public frmExpiredLoans()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void frmExpiredLoans_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {

        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {

        }
    }
}
