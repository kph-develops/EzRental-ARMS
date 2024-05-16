using ERAMSBoLayer;
using ERAMSDaLayer;
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
    public partial class frmCreditCardSearchMS : Form

    {
        CreditCard obj1;
        public frmCreditCardSearchMS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Step A - start Excption handling
            try
            {
                obj1 = new CreditCard();
                //Step2 - Call CreditCard Object Load(ID) method to execute the Data Access
                //by calling the Data Access Layer to execute the SELECT query
                //to the database and populate itself with the record returned
                //from the query

                //Step 3-If validate customer is found

                if (obj1.Load(searchBox.Text))
                {
                    //Step 4-Then Data is extracted from CreditCard object & placed on textboxes 
                    tfccn.Text = obj1.CreditCardNumber;
                    tfcon.Text = obj1.CreditCardOwnerName;
                    tfcpmscn.Text = obj1.CreditCardProcessingMerchantServiceCompanyName;
                    tfcncn.Text = obj1.CreditCardNetworkCompanyName;
                    tfcibn.Text = obj1.CreditCardIssuingBankName;
                    tfccmbn.Text = obj1.CreditCardCorporateMerchantBankName;
                    //  obj1.ExpDate.ToString("dd/MM/yyyy")
                    tfexp.Text = obj1.ExpDate.ToString("dd/MM/yyyy");
                    tfad1.Text = obj1.AddressLine1;
                    tfad2.Text = obj1.AddressLine2;
                    tfcity.Text = obj1.City;
                    tfstate.Text = obj1.StateCode;
                    tfzip.Text = obj1.ZipCode;
                    tfcounty.Text = obj1.Country;
                    tfccl.Text = obj1.CreditCardLimit.ToString();
                    tfcac.Text = obj1.CreditCardAvailableCredit.ToString();
                    tfcas.Text = obj1.CreditCardActivationStatus.ToString();
                }
                else
                {
                    //Step 5-prompt user CreditCard not found
                    MessageBox.Show("Credit Card Record Not Shown");
                    //Step 6-CAll the Clear() Method to Clear all controls
                    tfccn.Clear();
                    tfcon.Clear();
                    tfcpmscn.Clear();
                    tfcncn.Clear();
                    tfcibn.Clear();
                    tfccmbn.Clear();
                    tfexp.Clear();
                    tfad1.Clear();
                    tfad2.Clear();
                    tfcity.Clear();
                    tfstate.Clear();
                    tfzip.Clear();
                    tfcounty.Clear();
                    tfccl.Clear();
                    tfcac.Clear();
                    tfcas.Clear();
                    obj1 = null;
                }
            }
            catch (System.Exception) { 
            MessageBox.Show("Error in Search");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                //Step 1-Clear all controls by setting properties to blank
                tfccn.Text = "";
                tfcon.Text = "";
                tfcpmscn.Text = "";
                tfcncn.Text = "";
                tfcibn.Text = "";
                tfccmbn.Text = "";
                tfexp.Text = "";
                tfad1.Text = "";
                tfad2.Text = "";
                tfcity.Text = "";
                tfstate.Text = "";
                tfzip.Text = "";
                tfcounty.Text = "";
                tfccl.Text = "";
                tfcac.Text = "";
                tfcas.Text = "";
                searchBox.Clear();
                obj1 = null;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in clear");
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmCreditCardMSForm scene = new frmCreditCardMSForm();
            this.Hide();
            scene.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try {
               
                
                //Step1 – Test IF the Modular-Level CreditCard POINTER is NOT a null
                //and is populated with data returned from database from execution of the SEARCH feature
                if (obj1 != null)
                {
                    //Step2 - Call Moduler-level Pointer already pointing to the object to 
                    //Call the CreditCard Object Print() Method
                    obj1.Print();
                    //Step3 - Prompt the user information was sent to printer
                    MessageBox.Show("Record Sent To Network Printer");
                }
                else
                {
                    //Step5 - prompt the user that they need to search first before printing.
                    MessageBox.Show("Search For A Credit Card Before Printing");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in Print");
            }
            
        }
    }
}
