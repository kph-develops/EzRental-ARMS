using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERAMSDaLayer;
using System.IO;
using System.Runtime.InteropServices;

namespace ERAMSBoLayer
{
    public class CreditCard
    {
        /******************************************************************
    Private DATA Declarations
   ******************************************************************/
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private byte m_CreditCardProcessingMerchantServiceCompanyCode;
        private string m_CreditCardProcessingMerchantServiceCompanyName;
        private byte m_CreditCardNetworkCompanyCode;
        private string m_CreditCardNetworkCompanyName;
        private byte m_CreditCardIssuingBankCode;
        private string m_CreditCardIssuingBankName;
        private byte m_CreditCardCorporateMerchantBankCode;
        private string m_CreditCardCorporateMerchantBankName;
        private DateTime m_ExpDate;
        public string m_AddressLine1;
        private string m_AddressLine2;
        private string m_City;
        private string m_StateCode;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditCardLimit;
        private decimal m_CreditCardAvailableCredit;
        private bool m_CreditCardActivationStatus;


        /******************************************************************
      Public PROPERTIES Declarations
     ******************************************************************/
        //Public INSTANCE Properties Declarations
        public string CreditCardNumber { get; set; }
        public string CreditCardOwnerName { get; set; }

        public byte CreditCardProcessingMerchantServiceCompanyCode { get; set; }
        public string CreditCardProcessingMerchantServiceCompanyName { get; set; }

        public byte CreditCardNetworkCompanyCode { get; set; }
        public string CreditCardNetworkCompanyName { get; set; }

        public byte CreditCardIssuingBankCode { get; set; }
        public string CreditCardIssuingBankName { get; set; }

        public byte CreditCardCorporateMerchantBankCode { get; set; }
        public string CreditCardCorporateMerchantBankName { get; set; }

        public DateTime ExpDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public decimal CreditCardLimit { get; set; }
        public decimal CreditCardAvailableCredit { get; set; }

        public bool CreditCardActivationStatus { get; set; }

        /******************************************************************
  Default Constructor
  ******************************************************************/
        public CreditCard()
        {
            this.m_CreditCardNumber = "";
            this.m_CreditCardOwnerName = "";
            this.m_CreditCardProcessingMerchantServiceCompanyCode = 0;
            this.m_CreditCardProcessingMerchantServiceCompanyName = "";
            this.m_CreditCardNetworkCompanyCode = 0;
            this.m_CreditCardNetworkCompanyName = "";
            this.m_CreditCardIssuingBankCode = 0;
            this.m_CreditCardIssuingBankName = "";
            this.m_CreditCardCorporateMerchantBankCode = 0;
            this.m_CreditCardCorporateMerchantBankName = "";
            this.m_ExpDate = new DateTime().Date; // New Date Object with default date of 01/01/0001
            this.m_AddressLine1 = "";
            this.m_AddressLine2 = "";
            this.m_City = "";
            this.m_StateCode = "";
            this.m_ZipCode = "";
            this.m_Country = "";
            CreditCardLimit = 3000.0M;
           CreditCardAvailableCredit = 3000.0M;
            this.m_CreditCardActivationStatus = true;
        }


        public CreditCard(string ccnum, string cconame, byte ccpmscc, byte ccncc,
            byte ccibc, byte cccmbc, string exp, string add1, string add2, string city,
            string state, string zip, string ctr, decimal ccl = 3000.0M, decimal ccac = 3000.0M)
        {
            this.m_CreditCardNumber = ccnum;
            this.m_CreditCardOwnerName = cconame;
            this.m_CreditCardProcessingMerchantServiceCompanyCode = ccpmscc;
            this.m_CreditCardProcessingMerchantServiceCompanyName = "";
            this.m_CreditCardNetworkCompanyCode = ccncc;
            this.m_CreditCardNetworkCompanyName = "";
            this.m_CreditCardIssuingBankCode = ccibc;
            this.m_CreditCardIssuingBankName = "";
            this.m_CreditCardCorporateMerchantBankCode = cccmbc;
            this.m_CreditCardCorporateMerchantBankName = "";
            this.m_ExpDate = Convert.ToDateTime(exp); // New Date Object with default date of 01/01/0001
            this.m_AddressLine1 = add1;
            this.m_AddressLine2 = add2;
            this.m_City = city;
            this.m_StateCode = state;
            this.m_ZipCode = zip;
            this.m_Country = ctr;
            this.m_CreditCardActivationStatus = true;
            this.m_CreditCardLimit = ccl;
            this.m_CreditCardAvailableCredit = ccac;
        }

        ~CreditCard()
        {

        }
        // NEEDS WORK
        public void Print()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Network_Printer.txt",true);
                writer.WriteLine("Credit Card information:");
                writer.WriteLine("Credit Card Number = {0}", CreditCardNumber);
                writer.WriteLine("CreditCardOwnerName = {0}", CreditCardOwnerName);
                writer.WriteLine("CreditCardProcessingMerchantServiceCompanyCode = {0}", CreditCardProcessingMerchantServiceCompanyCode);
                writer.WriteLine("CreditCardProcessingMerchantServiceCompanyName = {0}", CreditCardProcessingMerchantServiceCompanyName);
                writer.WriteLine("CreditCardNetworkCompanyCode = {0}", CreditCardNetworkCompanyCode);
                writer.WriteLine("CreditCardNetworkCompanyName = {0}", CreditCardNetworkCompanyName);
                writer.WriteLine("CreditCardIssuingBankCode = {0}", CreditCardIssuingBankCode);
                writer.WriteLine("CreditCardIssuingBankName = {0}", CreditCardIssuingBankName);
                writer.WriteLine("CreditCardCorporateMerchantBankCode = {0}", CreditCardCorporateMerchantBankCode);
                writer.WriteLine("CreditCardCorporateMerchantBankName = {0}", CreditCardCorporateMerchantBankName);
                writer.WriteLine("Expiration Date = {0}", ExpDate);
                writer.WriteLine("AddressLine1 = {0}", AddressLine1);
                writer.WriteLine("AddressLine2 = {0}", AddressLine2);
                writer.WriteLine("City = {0}", City);
                writer.WriteLine("State = {0}", StateCode);
                writer.WriteLine("Zipcode = {0}", ZipCode);
                writer.WriteLine("Country = {0}", m_Country);
                writer.WriteLine("Credit Card Limit = {0}", CreditCardLimit);
                writer.WriteLine("CreditCardAvailableCredit = {0}", CreditCardAvailableCredit);
                writer.WriteLine("Credit Card Activation Status = {0}", CreditCardActivationStatus);
                writer.WriteLine("");
                writer.Flush();




                //   ExpirationDate = value as Short DateFormat(1 / 1 / 1900)



                writer.Close();
            }
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error printing file");
            }
            finally
            {

            }
        }

        public bool Activate()
        {
            this.m_CreditCardActivationStatus = true;
            return m_CreditCardActivationStatus;
        }

        public bool Deactivate()
        {
            this.m_CreditCardActivationStatus = false;
            return m_CreditCardActivationStatus;
        }

        public bool Load(String key)
        {
            bool temp = DALayer_Load(key);
            if (temp)
            {
                return true;
            }
            else { return false; }

        }

        public bool Insert()
        {
            bool temp = DALayer_Insert();
            if (temp)
            {
                return true;
            }
            else { return false; }

        }


        #region "PROTECTED INSTANCE & STATIC DATA ACCESS METHODS"

        /******************************************************************
          Protected DATA ACCESS METHODS Declarations
         ******************************************************************/

        //=================================================================
        //Name:        DALayer_Load(key) Method
        //Purpose:      Method that CALLS the Data Access Layer services 
        //              to do the work and query the database.
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    The key or ID of the object to load.
        //Return Value: Boolean true if found and retrieved from database, false 
        //              otherwise.

        //protected SEARCH Method should already exist from SPRINT #1

        //=================================================================
        //Name:        DALayer_Insert() Method
        //Purpose:      Method that CALLS the Data Access Layer services 
        //              to do the work of INSERTING record to the database.
        //Algorithm:    Calls the Data Access Layer to do the work
        //Parameter:    None.
        //Return Value: Boolean true if record inserted, false otherwise.
        protected bool DALayer_Insert()
        {
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();

                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objDTO = new CreditCardDTO();

                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objDTO.CreditCardNumber = this.CreditCardNumber;
                objDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objDTO.CreditCardProcessingMerchantServiceCompanyCode = this.CreditCardProcessingMerchantServiceCompanyCode;
                objDTO.CreditCardNetworkCompanyCode = this.CreditCardNetworkCompanyCode;
                objDTO.CreditCardIssuingBankCode = this.CreditCardIssuingBankCode;
                objDTO.CreditCardCorporateMerchantBankCode = this.CreditCardCorporateMerchantBankCode;
                objDTO.ExpDate = this.ExpDate;
                objDTO.AddressLine1 = this.AddressLine1;
                objDTO.AddressLine2 = this.AddressLine2;
                objDTO.City = this.City;
                objDTO.StateCode = this.StateCode;
                objDTO.ZipCode = this.ZipCode;
                objDTO.Country = this.Country;
                objDTO.CreditCardLimit = this.CreditCardLimit;
                objDTO.CreditCardAvailableCredit = this.CreditCardAvailableCredit;
                objDTO.CreditCardActivationStatus = this.CreditCardActivationStatus;


                //Step 5-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.Insert(objDTO);

                //Step 6- test if insert to database was successful return true,
                if (inserted == true)
                {
                    //Step 6a-Returns a true since this class object has been inserted & marked as old. 
                    return true;
                }
                else
                {
                    //Step 7- No record inserted, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error is DALayer_Insert() Method: {0} " + objE.Message);
            }
        }//End of Method

        protected bool DALayer_Load(string key)
        {
            //1.CREATE DATA ACCESS LAYER CLASS OBJECT objDALayer.
            //2.CALLS DATA ACCESS LAYER DATA ACCESS OBJECT objDAO.DALCustomerLoad(key) Method
            //to do the work which returns a POPULATED DATA TRANSBER OBJECT with the CreditCard’s record.
            //3.Consume the DTO Object RETURNED by the objDAO.DALCreditCardLoad(key) Method by GETTING all
            //the properties from the returned object and SETTING all the Properties / Data of THIS class
            //DATA or PROPERTIES.When done, THIS class OBJECT now contains the Customer’s DATA thus
            //represents the customer.
            //4. Return TRUE if table record data was returned from call to objDALayer.DALCreditCardLoad(key) Method
            //or FALSE if no data indicating the record was not found in the database.
            //6	Add Error-Handling code using Try-Catch-Finally to handle all required
            //Unique OR/AND GENERAL Exception & Re-Throw the Exception

            try
            {
                //STEP 1 - Use a POLYMORPHISM BASED CLASS DAL POINTER to get SQL Server Factory Data Access Object
                //via the  Factory to get the DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER)
                //Method, passign the SQLSERVER Constant which = 1.
                DALObjectFactoryBase objSQLDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();

                //Call the CreditCardDAO Data Access Object to do the work 
                CreditCardDTO objDTO = objCreditCardDAO.GetRecordByID(key);

                //Check if DTO object exists & populate this objct with DTO object's properties
                if (objDTO != null)
                {
                    //Get the data from the Data Transfer Object
                    this.CreditCardNumber = objDTO.CreditCardNumber;
                    this.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                    this.CreditCardProcessingMerchantServiceCompanyCode = objDTO.CreditCardProcessingMerchantServiceCompanyCode;
                    this.CreditCardProcessingMerchantServiceCompanyName = objDTO.CreditCardProcessingMerchantServiceCompanyName;
                    this.CreditCardNetworkCompanyCode = objDTO.CreditCardNetworkCompanyCode;
                    this.CreditCardNetworkCompanyName = objDTO.CreditCardNetworkCompanyName;
                    this.CreditCardIssuingBankCode = objDTO.CreditCardIssuingBankCode;
                    this.CreditCardIssuingBankName = objDTO.CreditCardIssuingBankName;
                    this.CreditCardCorporateMerchantBankCode = objDTO.CreditCardCorporateMerchantBankCode;
                    this.CreditCardCorporateMerchantBankName = objDTO.CreditCardCorporateMerchantBankName;
                    this.ExpDate = objDTO.ExpDate;
                    this.AddressLine1 = objDTO.AddressLine1;
                    this.AddressLine2 = objDTO.AddressLine2;
                    this.City = objDTO.City;
                    this.StateCode = objDTO.StateCode;
                    this.ZipCode = objDTO.ZipCode;
                    this.Country = objDTO.Country;
                    this.CreditCardLimit = objDTO.CreditCardLimit;
                    this.CreditCardAvailableCredit = objDTO.CreditCardAvailableCredit;


                    //Handle activation status
                    if (objDTO.CreditCardActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();
                    //since it has been populated, return true
                    return true;
                }
                else
                {
                    //if null or no object returned from DALayer, return false
                    return false;
                }
            }//End of try 
            catch (Exception objE)
            {
                //Rethrow general exceptions
                throw new Exception("Unexpected Error is DALayer_Load(key) Method: {0} " + objE.Message);
            }
            #endregion

        }
    }
}
