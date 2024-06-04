using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERAMSDaLayer;
using System.IO;

namespace ERAMSBoLayer
{
   public  class CreditCardNetworkCompany
    {
        public byte CreditCardNetworkCompanyCode { get; set; }
        public string CreditCardNetworkCompanyName { get; set; }

        public CreditCardNetworkCompany()
        {
            this.CreditCardNetworkCompanyCode = 0;
            this.CreditCardNetworkCompanyName = "";

        }
        public CreditCardNetworkCompany(byte ccncc, string ccncn)
        {
            this.CreditCardNetworkCompanyCode = ccncc;
            this.CreditCardNetworkCompanyName = ccncn;
        }

        ~CreditCardNetworkCompany()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Network_Printer.txt", true);
                writer.WriteLine("Network Company Infromation:");
                writer.WriteLine("Network Company Code = {0}", CreditCardNetworkCompanyCode);
                writer.WriteLine(" Network Company Name = {0}", CreditCardNetworkCompanyName);
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

        public static List<CreditCardNetworkCompany> GetAllCreditCardNetworkCompanies()
        {

            return DALayer_GetAllCreditCardNetworkCompanies();

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

        protected static List<CreditCardNetworkCompany> DALayer_GetAllCreditCardNetworkCompanies()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardNetworkCompanyDAO objCreditCardNetworkCompanyDAO = objDAOFactory.GetCreditCardNetworkCompanyDAO();

                //Step 3-call DAO object to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardNetworkCompanyDTO> objCreditCardNetworkCompanyDTOList = objCreditCardNetworkCompanyDAO.GetAllRecords();

                //Step 4- test if objCreditCardNetworkCompanyDTOList DTO collection exists (returned from DBMS) 
                if (objCreditCardNetworkCompanyDTOList != null)
                {

                    //Step 5-Create a LIST Collection of CreditCardNetworkCompany objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<CreditCardNetworkCompany> objCreditCardNetworkCompanyList = new List<CreditCardNetworkCompany>();

                    //Step 6-Loop through the objCreditCardNetworkCompanyDTOList
                    //collection
                    foreach (CreditCardNetworkCompanyDTO objDTO in objCreditCardNetworkCompanyDTOList)
                    {
                        //Step 6a-Create new CreditCardNetworkCompany object
                        CreditCardNetworkCompany objCreditCardNetworkCompany = new CreditCardNetworkCompany();

                        //Step 6b-get the data from DTO object and SET CreditCardNetworkCompany object
                        objCreditCardNetworkCompany.CreditCardNetworkCompanyCode = objDTO.CreditCardNetworkCompanyCode;
                        objCreditCardNetworkCompany.CreditCardNetworkCompanyName = objDTO.CreditCardNetworkCompanyName;

                        //Step 6c-Add CreditCardNetworkCompany Object to the objCreditCardNetworkCompanyList COLLECTION  
                        objCreditCardNetworkCompanyList.Add(objCreditCardNetworkCompany);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCreditCardMerchantList COLLECTION
                    return objCreditCardNetworkCompanyList;

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
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCardNetworkCompanies() Method: {0} " + objE.Message);

            }

        }//End of method



    }
}
