using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERAMSDaLayer;
using System.IO;

namespace ERAMSBoLayer
{
    public class CreditCardCorporateMerchantBank
    {
        public byte CreditCardCorporateMerchantBankCode { get; set; }
        public string CreditCardCorporateMerchantBankName { get; set; }

        public CreditCardCorporateMerchantBank()
        {
            this.CreditCardCorporateMerchantBankCode = 0;
            this.CreditCardCorporateMerchantBankName = "";

        }
        public CreditCardCorporateMerchantBank(byte cccmbc, string cccmbn)
        {
            this.CreditCardCorporateMerchantBankCode = cccmbc;
            this.CreditCardCorporateMerchantBankName = cccmbn;
        }

        ~CreditCardCorporateMerchantBank()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Network_Printer.txt", true);
                writer.WriteLine("Corporate Merchant Bank Infromation:");
                writer.WriteLine("Corporate Merchant Bank Code = {0}", CreditCardCorporateMerchantBankCode);
                writer.WriteLine("Corporate Merchant Bank Name = {0}", CreditCardCorporateMerchantBankName);
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

        public static List<CreditCardCorporateMerchantBank> GetAllCreditCardCorporateMerchantBanks()
        {

            return DALayer_GetAllCreditCardCorporateMerchantBanks();

        }

        /******************************************************************
         Protected DATA ACCESS METHODS Declarations
        ******************************************************************/

        //=================================================================
        //Name:         STATIC DALayer_GetAllCreditCardCorporateMerchantBanks() 
        //Purpose:      protected STATIC Data Access Method that executes the 
        //              fetching of all the CreditCard Corporate Merchant Bank
        //              records from the database.
        //Algorithm:    Step 1-Calls the DALObjectFactoryBase
        //              GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER)  
        //              method in the Data Access Layer services
        //              using POLYMORPHISM to get a SQLServerDAOFactory Object.
        //              Uses the SQLServerDAOFactory Object GetCreditCardCorporateMerchantBankDAO()
        //              Method to GET a GetCreditCardCorporateMerchantBankyDAO Object 
        //              to perform the data access by calling its GetAllRecords()
        //              Method to do the work and  
        //              query the database and return a LIST COLLECTION  
        //              of of all the CreditCard Corporate Merchant Banks 
        //              in the database table.
        //Parameter:    None.
        //Return Value: LIST COLLECTION with all the CreditCard Corporate Merchant Bank records.

        protected static List<CreditCardCorporateMerchantBank> DALayer_GetAllCreditCardCorporateMerchantBanks()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardCorporateMerchantBankDAO objCreditCardCorporateMerchantBankDAO = objDAOFactory.GetCreditCardCorporateMerchantBankDAO();

                //Step 3-call DAO object to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardCorporateMerchantBankDTO> objCreditCardCorporateMerchantBankDTOList = objCreditCardCorporateMerchantBankDAO.GetAllRecords();

                //Step 4- test if objCreditCardNetworkCompanyDTOList DTO collection exists (returned from DBMS) 
                if (objCreditCardCorporateMerchantBankDTOList != null)
                {

                    //Step 5-Create a LIST Collection of CreditCardNetworkCompany objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<CreditCardCorporateMerchantBank> objCreditCardCorporateMerchantBankList = new List<CreditCardCorporateMerchantBank>();

                    //Step 6-Loop through the objCreditCardNetworkCompanyDTOList
                    //collection
                    foreach (CreditCardCorporateMerchantBankDTO objDTO in objCreditCardCorporateMerchantBankDTOList)
                    {
                        //Step 6a-Create new CreditCardNetworkCompany object
                        CreditCardCorporateMerchantBank objCreditCardCorporateMerchantBank = new CreditCardCorporateMerchantBank();

                        //Step 6b-get the data from DTO object and SET CreditCardNetworkCompany object
                        objCreditCardCorporateMerchantBank.CreditCardCorporateMerchantBankCode = objDTO.CreditCardCorporateMerchantBankCode;
                        objCreditCardCorporateMerchantBank.CreditCardCorporateMerchantBankName = objDTO.CreditCardCorporateMerchantBankName;

                        //Step 6c-Add CreditCardNetworkCompany Object to the objCreditCardNetworkCompanyList COLLECTION  
                        objCreditCardCorporateMerchantBankList.Add(objCreditCardCorporateMerchantBank);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCreditCardMerchantList COLLECTION
                    return objCreditCardCorporateMerchantBankList;

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
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCardCorporateMerchantBank() Method: {0} " + objE.Message);

            }

        }//End of method
    }
}
