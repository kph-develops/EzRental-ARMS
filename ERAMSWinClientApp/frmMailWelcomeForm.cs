using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERAMSWinClientApp
{
    public partial class frmMailWelcomeForm : Form
    {
        public frmMailWelcomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {

        }

        private void frmMailWelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnERP_Click(object sender, EventArgs e)
        {
            frmERPSystemForm obj1 = new frmERPSystemForm();
            this.Hide();

            obj1.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
