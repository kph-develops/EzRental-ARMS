using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERAMSDaLayer;
using System.IO;

namespace ERAMSBoLayer
{
    public class CreditCardIssuingBank
    {

        public byte CreditCardIssuingBankCode { get; set; }
        public string CreditCardIssuingBankName { get; set; }

        public CreditCardIssuingBank()
        {
            this.CreditCardIssuingBankCode = 0;
            this.CreditCardIssuingBankName = "";

        }
        public CreditCardIssuingBank (byte ccibc, string ccibn)
        {
            this.CreditCardIssuingBankCode = ccibc;
            this.CreditCardIssuingBankName = ccibn;
        }

        ~CreditCardIssuingBank()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Network_Printer.txt", true);
                writer.WriteLine("Issuing Bank Infromation:");
                writer.WriteLine("Issuing Bank Code = {0}", CreditCardIssuingBankCode);
                writer.WriteLine(" Issuing Bank Name = {0}", CreditCardIssuingBankName);
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

        public static List<CreditCardIssuingBank> GetAllCreditCardIssuingBanks()
        {

            return DALayer_GetAllCreditCardIssuingBanks();

        }

        /******************************************************************
         Protected DATA ACCESS METHODS Declarations
        ******************************************************************/

        //=================================================================
        //Name:         STATIC DALayer_GetAllCreditCardNetworkCompanies() 
        //Purpose:      protected STATIC Data Access Method that executes the 
        //              fetching of all the Credit Card Network Company
        //              records from the database.
        //Algorithm:    Step 1-Calls the DALObjectFactoryBase
        //              GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER)  
        //              method in the Data Access Layer services
        //              using POLYMORPHISM to get a SQLServerDAOFactory Object.
        //              Uses the SQLServerDAOFactory Object GetCreditCardNetworkCompanyDAO()
        //              Method to GET a GetCreditCardNetworkCompanyDAO Object 
        //              to perform the data access by calling its GetAllRecords()
        //              Method to do the work and  
        //              query the database and return a LIST COLLECTION  
        //              of of all the Credit Card Network Companies 
        //              in the database table.
        //Parameter:    None.
        //Return Value: LIST COLLECTION with all the Credit Card
        //              Network Company records.

        protected static List<CreditCardIssuingBank> DALayer_GetAllCreditCardIssuingBanks()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardIssuingBankDAO objCreditCardIssuingBankDAO = objDAOFactory.GetCreditCardIssuingBankDAO();

                //Step 3-call DAO object to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardIssuingBankDTO> objCreditCardIssuingBankDTOList = objCreditCardIssuingBankDAO.GetAllRecords();

                //Step 4- test if objCreditCardNetworkCompanyDTOList DTO collection exists (returned from DBMS) 
                if (objCreditCardIssuingBankDTOList != null)
                {

                    //Step 5-Create a LIST Collection of CreditCardNetworkCompany objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<CreditCardIssuingBank> objCreditCardIssuingBankList = new List<CreditCardIssuingBank>();

                    //Step 6-Loop through the objCreditCardNetworkCompanyDTOList
                    //collection
                    foreach (CreditCardIssuingBankDTO objDTO in objCreditCardIssuingBankDTOList)
                    {
                        //Step 6a-Create new CreditCardNetworkCompany object
                        CreditCardIssuingBank objCreditCardIssuingBank = new CreditCardIssuingBank();

                        //Step 6b-get the data from DTO object and SET CreditCardNetworkCompany object
                        objCreditCardIssuingBank.CreditCardIssuingBankCode = objDTO.CreditCardIssuingBankCode;
                        objCreditCardIssuingBank.CreditCardIssuingBankName = objDTO.CreditCardIssuingBankName;

                        //Step 6c-Add CreditCardNetworkCompany Object to the objCreditCardNetworkCompanyList COLLECTION  
                        objCreditCardIssuingBankList.Add(objCreditCardIssuingBank);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCreditCardMerchantList COLLECTION
                    return objCreditCardIssuingBankList;

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
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCardIssuingBanks() Method: {0} " + objE.Message);

            }

        }//End of method

    }
}
