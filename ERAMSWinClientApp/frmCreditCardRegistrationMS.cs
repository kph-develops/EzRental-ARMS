using ERAMSBoLayer;
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
    public partial class frmCreditCardRegistrationMS : Form
    {
        public frmCreditCardRegistrationMS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adrl1lbl_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCreditCardRegistrationMS_Load(object sender, EventArgs e)
        {
            try
            {

                //=====================================================================================================================================
                //BINDING cbCreditCardProcessingMerchantServiceCompany ComboBox to the CreditCardProcessingMerchantServiceCompany Class GetAllCreditCardMerchants Static Method
                cbcpmscn.DataSource = CreditCardProcessingMerchantServiceCompany.GetAllCreditCardProcessingMerchantServiceCompanies();

                //Set DisplayMember property to indicate which property gets displayed on the combobox
                //Set ValueMember Property to indicate which property to get data from in the code
                cbcpmscn.DisplayMember = "CreditCardProcessingMerchantServiceCompanyName";
                cbcpmscn.ValueMember = "CreditCardProcessingMerchantServiceCompanyCode";  //in this case we return the code

//=====================================================================================================================================
//BINDING cbCreditCardNetworkCompanyName ComboBox to the CreditCardNetworkCompnay Class GetCreditCardNetworkCompanies Static Method
                cbcncn.DataSource = CreditCardNetworkCompany.GetAllCreditCardNetworkCompanies();

                //Set DisplayMember property to indicate which property gets displayed on the combobox
                //Set ValueMember Property to indicate which property to get data from in the code
                cbcncn.DisplayMember = "CreditCardNetworkCompanyName";
                cbcncn.ValueMember = "CreditCardNetworkCompanyCode";  //in this case we return the code

                //=====================================================================================================================================
                //BINDING cbCreditCardIssuingBankName ComboBox to the CreditCardCreditCardIssuingBank Class GetCreditCardIssuingBanks Static Method
                cbcibn.DataSource = CreditCardIssuingBank.GetAllCreditCardIssuingBanks();

                //Set DisplayMember property to indicate which property gets displayed on the combobox
                //Set ValueMember Property to indicate which property to get data from in the code
                cbcibn.DisplayMember = "CreditCardIssuingBankName";
                cbcibn.ValueMember = "CreditCardIssuingBankCode";  //in this case we return the code
                
                //=====================================================================================================================================
                //BINDING cbCreditCardCorporateMerchantBankName ComboBox to the CreditCardCorporateMerchantBank Class GetCreditCardCorporateMerchantBanks Static Method
                cbccmbn.DataSource = CreditCardCorporateMerchantBank.GetAllCreditCardCorporateMerchantBanks();

                //Set DisplayMember property to indicate which property gets displayed on the combobox
                //Set ValueMember Property to indicate which property to get data from in the code
                cbccmbn.DisplayMember = "CreditCardCorporateMerchantBankName";
                cbccmbn.ValueMember = "CreditCardCorporateMerchantBankCode";//in this case we return the code


                //=====================================================================================================================================
                //BINDING State ComboBox to the USState Class GetAllUSStates Static Method
                cbstate.DataSource = USState.GetAllUSStates();

                //Set DisplayMember property to indicate which property gets displayed on the combobox
                //Set ValueMember Property to indicate which property to get data from in the code
                cbstate.DisplayMember = "StateName";
                cbstate.ValueMember = "StateCode";           //in this case we return the state code

                //=====================================================================================================================================
                //BINDING Country ComboBox to the Country Class GetAllCountry Static Method
                cbCountry.DataSource = Country.GetAllCountries();

                //Set DisplayMember property to indicate which property gets displayed on the combobox
                //Set ValueMember Property to indicate which property is GOTTEN to used in the code
                cbCountry.DisplayMember = "CountryName";
                cbCountry.ValueMember = "CountryName";        //in this case we return the country name since the CreditCard Class stores the 
                                                              //Name

                //=====================================================================================================================================
                //Initialized Credit Card Limit & Credit Card Available Credit Text boxes
                //Create Default object & set text boxes with properties from object
                CreditCard objCreditCard = new CreditCard();

                //SET textboxes text properties with content from temp creditcard object
                txtCreditCardLimit.Text = Convert.ToString(objCreditCard.CreditCardLimit);
               // MessageBox.Show(Convert.ToString(objCreditCard.CreditCardLimit));
                txtCreditCardAvailableCredit.Text = Convert.ToString(objCreditCard.CreditCardAvailableCredit);

                //=====================================================================================================================================
                //Programmatically set the properties to the Activation Status Combo Box
                //and ADD the activated and deactivated items to the Combo Box
                cbcas.Items.Add("Activate");
                cbcas.Items.Add("Deactivate");

                //SET SELECTED TEXT Property of ComboBox to Activate which is default status
                cbcas.SelectedItem = "Activate";


            }//End of Try
            catch (Exception objE)
            {
                MessageBox.Show("Unexpected error in Form_Load Event-Handler, please contact administrator " + objE);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            frmCreditCardMSForm scene = new frmCreditCardMSForm();
            this.Hide();
            scene.ShowDialog();
            
        }

        private void clickReglbl_Click(object sender, EventArgs e)
        {

        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard objCard = new CreditCard();
                objCard.CreditCardNumber = tbccn.Text;
                objCard.CreditCardOwnerName = tbcon.Text;
                objCard.CreditCardProcessingMerchantServiceCompanyName = cbcpmscn.GetItemText(cbcncn.SelectedItem);
                objCard.CreditCardProcessingMerchantServiceCompanyCode = (byte)cbcpmscn.SelectedValue;
                objCard.CreditCardNetworkCompanyName = cbcncn.GetItemText(cbcncn.SelectedItem);
                objCard.CreditCardNetworkCompanyCode = (byte)cbcncn.SelectedValue;
                objCard.CreditCardIssuingBankName = cbcibn.GetItemText(cbcncn.SelectedItem);
                objCard.CreditCardIssuingBankCode = (byte)cbcibn.SelectedValue;
                objCard.CreditCardCorporateMerchantBankName = cbccmbn.GetItemText(cbcncn.SelectedItem);
                objCard.CreditCardCorporateMerchantBankCode = (byte)cbccmbn.SelectedValue;
                // EXPDATE NEEDS TO GO HERE  (VERIFY IT WORKS)
                objCard.ExpDate = dtpExpDate.Value.Date;
                objCard.AddressLine1 = tbadrl1.Text;
                objCard.AddressLine2 = tbadrl2.Text;
                objCard.City = tbcity.Text;
                // NEEDS TO GO STATE HERE
                objCard.StateCode = (string)cbstate.SelectedValue;
                objCard.ZipCode = tbzip.Text;
                objCard.Country = cbCountry.GetItemText(cbCountry.SelectedItem);
                if (decimal.TryParse(txtCreditCardLimit.Text, out decimal parsedValue))
                {
                    objCard.CreditCardLimit = parsedValue;
                }
                else
                {
                    // Handle parsing error (invalid input)
                    MessageBox.Show("Invalid input. Please enter a valid decimal number.");
                }
                if (decimal.TryParse(txtCreditCardAvailableCredit.Text, out decimal parsedValue2))
                {
                    objCard.CreditCardAvailableCredit = parsedValue2;
                }
                else
                {
                    // Handle parsing error (invalid input)
                    MessageBox.Show("Invalid input. Please enter a valid decimal number.");
                }

                string activationChoice = cbcas.SelectedItem?.ToString();

                // Set the IsActivated property based on the selected item
                if (activationChoice == "Activate")
                {
                    objCard.CreditCardActivationStatus = true;
                }
                else if (activationChoice == "Deactivate")
                {
                    objCard.CreditCardActivationStatus = false;
                }

                if (objCard.Insert())
                {
                    MessageBox.Show("Credit Card Inserted Succesfully");
                }
                else
                {
                    MessageBox.Show("Unable to add Credit Card. Please Contact Administrator");
                }
            }
            catch (System.Exception)
            {
                //Step C- throw system exception since run time error has occured;
                MessageBox.Show("Unexpected Registration Error! Contact the IT Support Desk!");
}

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            CreditCard objclear = new CreditCard();
            tbccn.Text = "";
            tbcon.Text = "";
            cbcpmscn.SelectedIndex = -1;
            cbcncn.SelectedIndex = -1;
            cbcibn.SelectedIndex = -1;
            cbccmbn.SelectedIndex = -1;
            dtpExpDate.Value = DateTime.Today;
            tbadrl1.Text = "";
            tbadrl2.Text = "";
            tbcity.Text = "";
            cbstate.SelectedIndex = -1;
            tbzip.Text = "";
            cbCountry.SelectedIndex = -1;
            txtCreditCardLimit.Text = Convert.ToString(objclear.CreditCardLimit);
            txtCreditCardAvailableCredit.Text = Convert.ToString(objclear.CreditCardAvailableCredit);
            cbcas.SelectedItem = "Activate";
            
        }
    }
}
