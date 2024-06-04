using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERAMSDaLayer;
using System.IO;

namespace ERAMSBoLayer
{
    public class CreditCardProcessingMerchantServiceCompany
    {

        /******************************************************************
    Public  DATA Properties
   ******************************************************************/
     
        public byte CreditCardProcessingMerchantServiceCompanyCode { get; set; }
        public string CreditCardProcessingMerchantServiceCompanyName { get; set; }

        public CreditCardProcessingMerchantServiceCompany()
        {
            this.CreditCardProcessingMerchantServiceCompanyCode = 0;
            this.CreditCardProcessingMerchantServiceCompanyName = "";

        }
        public CreditCardProcessingMerchantServiceCompany(byte ccpmscc, string ccpmscn)
        {
            this.CreditCardProcessingMerchantServiceCompanyCode = ccpmscc;
            this.CreditCardProcessingMerchantServiceCompanyName = ccpmscn;
        }

        ~CreditCardProcessingMerchantServiceCompany()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Network_Printer.txt", true);
                writer.WriteLine("Merchant Infromation:");
                writer.WriteLine(" Merchant  Code = {0}", CreditCardProcessingMerchantServiceCompanyCode);
                writer.WriteLine(" Merchant  Name = {0}", CreditCardProcessingMerchantServiceCompanyName);
                writer.Flush();
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

        public static List<CreditCardProcessingMerchantServiceCompany> GetAllCreditCardProcessingMerchantServiceCompanies()
        {
          


           return DALayer_GetAllCreditCardProcessingMerchantServiceCompanies();
            
        }
        #region "PROTECTED BUSINESS LAYER DATA ACCESS METHODS DECLARATIONS"

        /******************************************************************
          Protected DATA ACCESS METHODS Declarations
         ******************************************************************/

        //=================================================================
        //Name:         STATIC DALayer_GetAllCreditCardProcessingMerchantServiceCompanies() 
        //Purpose:      protected STATIC Data Access Method that executes the 
        //              fetching of all the Credit Card Processing Merchant
        //              Service Company records from the database.
        //Algorithm:    Step 1-Calls the DALObjectFactoryBase
        //              GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER)  
        //              method in the Data Access Layer services
        //              using POLYMORPHISM to get a SQLServerDAOFactory Object.
        //              Uses the SQLServerDAOFactory Object
        //              GetCreditCardProcessingMerchantServiceCompanyDAO() 
        //              to GET a CreditCardProcessingMerchantServiceCompanyDAO 
        //              Object to perform the data access by calling its
        //              GetAllRecords() Method to do the work and  
        //              query the database and return a LIST COLLECTION  
        //              of of all the Credit Card Processing Merchant 
        //              Companies in the database table.
        //Parameter:    None.
        //Return Value: LIST COLLECTION with all the Credit Card Processing
        //              Merchant Companu records.

        protected static List<CreditCardProcessingMerchantServiceCompany> DALayer_GetAllCreditCardProcessingMerchantServiceCompanies()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardProcessingMerchantServiceCompanyDAO objCreditCardProcessingMerchantServiceCompanyDAO = objDAOFactory.GetCreditCardProcessingMerchantServiceCompanyDAO();

                //Step 3-call DAO object to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardProcessingMerchantServiceCompanyDTO> objCreditCardProcessingMerchantServiceCompanyDTOList = objCreditCardProcessingMerchantServiceCompanyDAO.GetAllRecords();

                //Step 4- test if objCreditCardProcessingMerchantServiceCompanyDTOList DTO collection exists (returned from DBMS) 
                if (objCreditCardProcessingMerchantServiceCompanyDTOList != null)
                {
                    //Step 5-Create a LIST Collection of Credit Card Merchant objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<CreditCardProcessingMerchantServiceCompany> objCreditCardProcessingMerchantServiceCompanyList = new List<CreditCardProcessingMerchantServiceCompany>();

                    //Step 6-Loop through the objCreditCardProcessingMerchantServiceCompanyDTOList collection
                    foreach (CreditCardProcessingMerchantServiceCompanyDTO objDTO in objCreditCardProcessingMerchantServiceCompanyDTOList)
                    {
                        //Step 6a-Create new CreditCardProcessingMerchantServiceCompany object
                        CreditCardProcessingMerchantServiceCompany objCreditCardProcessingMerchantServiceCompany = new CreditCardProcessingMerchantServiceCompany();

                        //Step 6b-get the data from DTO object and SET Credit Card Merchant object
                        objCreditCardProcessingMerchantServiceCompany.CreditCardProcessingMerchantServiceCompanyCode = objDTO.CreditCardProcessingMerchantServiceCompanyCode;
                        objCreditCardProcessingMerchantServiceCompany.CreditCardProcessingMerchantServiceCompanyName = objDTO.CreditCardProcessingMerchantServiceCompanyName;

                        //Step 6c-Add CreditCardMerchant Object to the objCreditCardProcessingMerchantServiceCompanyList COLLECTION  
                        objCreditCardProcessingMerchantServiceCompanyList.Add(objCreditCardProcessingMerchantServiceCompany);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCreditCardMerchantList COLLECTION
                    return objCreditCardProcessingMerchantServiceCompanyList;

                }//End of if
                else
                {
                    //Step 6e- No DTO collection object returned from DALayer, return a null
                    return null;
                }
            }//End of try
            //Step B-Traps for general exception.  
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCardProcessingMerchantServiceCompanies() Method: {0} " + objE.Message);

            }

        }//End of method

        #endregion

    }
}
