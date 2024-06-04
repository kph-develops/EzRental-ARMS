using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAMSDaLayer
{
  public  class SQLServerDAOFactory : DALObjectFactoryBase
    {

        //=================================================================
        //Name:         ConnectionString() Method
        //Purpose:      Centralized method that returns the Connection  
        //              String for MS SQLServer data access.
        //Parameter:    None.
        //Return Value: string that contains the connection string.
        public static string ConnectionString()
        {
            return "Data Source =.\\SQLExpress; Initial Catalog = EZRentalDB; Integrated Security = True";

        }

        //=================================================================
        //Name:         GetCreditCardDAO() Method
        //Purpose:      Method that returns the CreditCardDAO Data Access Object 
        //              that handles the data access for the CreditCard 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardDAO object.
        public override CreditCardDAO GetCreditCardDAO()
        {
            //return CreditCardDAO Data Access Object to perform CreditCard class Data Access
            return new CreditCardDAO();
        }


        /***********************************************************************/
        //Name:         GetCreditCardProcessingMerchantServiceCompanyDAO() Method
        //Purpose:      Method that returns the CreditCardProcessingMerchantServiceCompanyDAO 
        //              Data Access Object that handles the data access for the 
        //              CreditCardProcessingMerchantServiceCompany class in the 
        //              business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardProcessingMerchantServiceCompanyDAO object.
        public override CreditCardProcessingMerchantServiceCompanyDAO GetCreditCardProcessingMerchantServiceCompanyDAO()
        {
            //return CreditCardProcessingMerchantServiceCompanyDAO Data Access Object
            //to perform the Data Access on behalf of the 
            //of the CreditCardProcessingMerchantServiceCompany class Business Class 
            return new CreditCardProcessingMerchantServiceCompanyDAO();

        }

        /***********************************************************************/
        //Name:         GetCreditCardNetworkCompanyDAO() Method
        //Purpose:      Method that returns the CreditCardNetworkCompanyDAO 
        //              Data Access Object that handles the data access for the 
        //              CreditCardNetworkCompanyclass in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardNetworkCompanyDAO object.
        public override CreditCardNetworkCompanyDAO GetCreditCardNetworkCompanyDAO()
        {
            //return CreditCardNetworkCompanyDAO Data Access Object
            //to perform the Data Access on behalf of the 
            //of the CreditCardNetworkCompany Business Class 
            return new CreditCardNetworkCompanyDAO();

        }


        /***********************************************************************/
        //Name:         GetCreditCardIssuingBankDAO() Method
        //Purpose:      Method that returns the CreditCardIssuingBankDAO 
        //              Data Access Object that handles the data access for the 
        //              CreditCardIssuingBank class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardIssuingBankDAO object.
        public override CreditCardIssuingBankDAO GetCreditCardIssuingBankDAO()
        {
            //return CreditCardIssuingBankDAO Data Access Object
            //to perform the Data Access on behalf of the 
            //of the CreditCardIssuingBank Business Class 
            return new CreditCardIssuingBankDAO();

        }


        /***********************************************************************/
        //Name:         GetCreditCardCorporateMerchantBankDAO() Method
        //Purpose:      Method that returns the CreditCardCorporateMerchantBankDAO 
        //              Data Access Object that handles the data access for the 
        //              CreditCardCorporateMerchantBank class in the 
        //              business object Layer.
        //Parameter:    None.
        //Return Value: a new CreditCardCorporateMerchantBankDAO object.
        public override CreditCardCorporateMerchantBankDAO GetCreditCardCorporateMerchantBankDAO()
        {
            //return CreditCardCorporateMerchantBankDAO Data Access Object
            //to perform the Data Access on behalf of the 
            //of the CorporateMerchantBank class Business Class 
            return new CreditCardCorporateMerchantBankDAO();

        }


        /***********************************************************************/
        //Name:         GetUSStateDAO() Method
        //Purpose:      Method that returns the USStateDAO Data Access Object 
        //              that handles the data access for the USState 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new USStateDAO object.
        public override USStateDAO GetUSStateDAO()
        {
            //return USStateDAO Data Access Object to perform USState class Data Access
            return new USStateDAO();

        }


        /***********************************************************************/
        //Name:         GetCountryDAO() Method
        //Purpose:      Method that returns the CountryDAO Data Access Object 
        //              that handles the data access for the Country 
        //              class in the business object Layer.
        //Parameter:    None.
        //Return Value: a new CountryDAO object.
        public override CountryDAO GetCountryDAO()
        {
            //return CountryDAO Data Access Object to perform Country class Data Access
            return new CountryDAO();

        }



    }
}
