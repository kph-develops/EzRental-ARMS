using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERAMSDaLayer;
using System.IO;

namespace ERAMSBoLayer
{
    public class USState
    {
        public byte StateID { get; set; }
        public string StateCode { get; set; }
      
        public string StateName { get; set; }

        public USState()
        {
            this.StateID = 0;
            this.StateCode = "";
            this.StateName = "";

        }
        public USState(byte sid, string sc, string sn)
        {
            this.StateID = sid;
            this.StateCode = sc;
            this.StateName = sn;
        }

        ~USState()
        {

        }

        public void Print()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Network_Printer.txt", true);
                writer.WriteLine("US State Infromation:");
                writer.WriteLine("State ID = {0}", StateID);
                writer.WriteLine("State Code= {0}", StateCode);
                writer.WriteLine("State Name= {0}", StateName);
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

        public static List<USState> GetAllUSStates()
        {

            return DALayer_GetAllUSStates();

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

        protected static List<USState> DALayer_GetAllUSStates()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory Base Class POINTER to get the SQL Server FACTORY 
                //Data Access Object using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);

                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                USStateDAO objUSStateDAO = objDAOFactory.GetUSStateDAO();

                //Step 3-call DAO object to do the work & return COLLECTION of Data Transfer Objects
                List<USStateDTO> objUSStateDTOList = objUSStateDAO.GetAllRecords();

                //Step 4- test if objUSStateDTOList DTO collection exists (returned from DBMS) 
                if (objUSStateDTOList != null)
                {

                    //Step 5-Create a LIST Collection of USState objects to populate with 
                    //the data from each DTO Object in of DTO collection
                    List<USState> objUSStateList = new List<USState>();

                    //Step 6-Loop through the objUSStateDTOList
                    //collection
                    foreach (USStateDTO objDTO in objUSStateDTOList)
                    {
                        //Step 6a-Create new CreditCardNetworkCompany object
                        USState objUSState = new USState();

                        //Step 6b-get the data from DTO object and SET CreditCardNetworkCompany object
                        objUSState.StateID = objDTO.StateID;
                        objUSState.StateCode = objDTO.StateCode;
                        objUSState.StateName = objDTO.StateName;


                        //Step 6c-Add CreditCardNetworkCompany Object to the objCreditCardNetworkCompanyList COLLECTION  
                        objUSStateList.Add(objUSState);

                    }//End of foreach

                    //Step 6d-once copy process ends, Return objCountrytList COLLECTION
                    return objUSStateList;

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
                throw new Exception("Unexpected Error in DALayer_GetAllStates() Method: {0} " + objE.Message);

            }

        }//End of method
    }
}
