using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERAMSDaLayer;
using System.IO;

namespace ERAMSBoLayer
{
    public class Country
    {
        public byte CountryID { get; set; }
        public string CountryCode2Char { get; set; }
        public string CountryCode3Char { get; set; }
        public string CountryName { get; set; }

        public Country()
        {
            this.CountryID = 0;
            this.CountryCode2Char = "";
            this.CountryCode3Char = "";
            this.CountryName = "";

        }
        public Country (byte cid, string cc2 , string cc3, string cn)
        {
            this.CountryID = cid;
            this.CountryCode2Char = cc2;
            this.CountryCode3Char = cc3;
            this.CountryName = cn;
        }

        ~Country()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Network_Printer.txt", true);
                writer.WriteLine("Country Infromation:");
                writer.WriteLine("Country ID = {0}", CountryID);
                writer.WriteLine("Country Code 2 Characters = {0}", CountryCode2Char);
                writer.WriteLine("Country Code 3 Characters = {0}", CountryCode3Char);
                writer.WriteLine("Country Name = {0}", CountryName);
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

        public static List<Country> GetAllCountries()
        {

            return DALayer_GetAllCountries();

        }

        /******************************************************************
         Protected DATA ACCESS METHODS Declarations
        ******************************************************************/

        //=================================================================
        //Name:         STATIC DALayer_GetAllCountries() 
        //Purpose:      protected STATIC Data Access Method that executes the 
        //              fetching of all the Country 
        //              records from the database.
        //Algorithm:    Step 1-Calls the DALObjectFactoryBase
        //              GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER)  
        //              method in the Data Access Layer services
        //              using POLYMORPHISM to get a SQLServerDAOFactory Object.
        //              Uses the SQLServerDAOFactory Object GetCountryDAO()
        //              Method to GET a GetCountryDAO Object 
        //              to perform the data access by calling its GetAllRecords()
        //              Method to do the work and  
        //              query the database and return a LIST COLLECTION  
        //              of of all the Countries
        //              in the database table.
        //Parameter:    None.
        //Return Value: LIST COLLECTION with all the Country records.

        protected static List<Country> DALayer_GetAllCountries()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CountryDAO objCountryDAO = objDAOFactory.GetCountryDAO();

                //Step 3-call DAO object to do the work & return COLLECTION of Data Transfer Objects
                List<CountryDTO> objCountryDTOList = objCountryDAO.GetAllRecords();

                //Step 4- test if objCountryDTOList DTO collection exists (returned from DBMS) 
                if (objCountryDTOList != null)
                {

                    //Step 5-Create a LIST Collection of Country objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<Country> objCountryList = new List<Country>();

                    //Step 6-Loop through the objCountryDTOList
                    //collection
                    foreach (CountryDTO objDTO in objCountryDTOList)
                    {
                        //Step 6a-Create new CreditCardNetworkCompany object
                        Country objCountry = new Country();

                        //Step 6b-get the data from DTO object and SET CreditCardNetworkCompany object
                        objCountry.CountryID = objDTO.CountryID;
                        objCountry.CountryCode2Char = objDTO.CountryCode2Char;
                        objCountry.CountryCode3Char = objDTO.CountryCode3Char;
                        objCountry.CountryName = objDTO.CountryName;
                        

                        //Step 6c-Add CreditCardNetworkCompany Object to the objCreditCardNetworkCompanyList COLLECTION  
                        objCountryList.Add(objCountry);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCountrytList COLLECTION
                    return objCountryList;

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
                throw new Exception("Unexpected Error in DALayer_GetAllCCountries() Method: {0} " + objE.Message);

            }

        }//End of method
    }
}
