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
    public partial class frmCreditCardMSForm : Form
    {
        public frmCreditCardMSForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmERPSystemForm scene2 = new frmERPSystemForm();
             this.Hide();
            scene2.ShowDialog();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCreditCardSearchMS scene = new frmCreditCardSearchMS();
            this.Hide();
            scene.ShowDialog();
            
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmCreditCardRegistrationMS window = new frmCreditCardRegistrationMS();
            this.Hide();
            window.ShowDialog();
        }
    }
}
