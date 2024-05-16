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
    public partial class frmERPSystemForm : Form
    {
        public frmERPSystemForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnHR_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditCardMS_Click(object sender, EventArgs e)
        {
            frmCreditCardMSForm obj2 = new frmCreditCardMSForm();

            this.Hide();

            obj2.ShowDialog();
        }

        private void btnVehicleInventoryMS_Click(object sender, EventArgs e)
        {

        }
    }
}
