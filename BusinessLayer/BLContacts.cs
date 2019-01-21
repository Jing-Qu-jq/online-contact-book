using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccess;
using System.Data;

namespace BusinessLayer
{
    public class BLContacts
    {

        public static List<ContactInformation> GetContactsList()
        {
            ContactInformation Contact = new ContactInformation();
            var ContactsList = new List<ContactInformation>();
            DataSet dsGetContactsReport = new DataSet();

            //Calling service
            //var testService =  new MyDemographicsInfoService.MyDemographicsInfoServiceClient();
            //var testServ = new DemoInformationService.DemoInformationServiceClient();
            //Get the demographics data by NOT USING the database
            //dsGetDemographicsReport = DADemographicsInformation.GetDemographicsWithOutDB();
            //dsGetDemographicsReport = testService.GetDemographicsWithOutDB();

            //Get the demographics from database but get the connection string details from web.Config file
            //dsGetDemographicsReport = DADemographicsInformation.GetDemographicsUsingDBWithConfig();
            //dsGetDemographicsReport = testService.GetDemographicsUsingDBWithConfig();

            //Get the demographics from database but define the connection string in this method
            dsGetContactsReport = DAContactsInformation.GetContactsUsingDBWithConfig();
            //dsGetDemographicsReport = testService.GetDemographicsUsingDBWithOutConfig();

            if (dsGetContactsReport.Tables.Count > 0)
            {
                ContactsList = dsGetContactsReport.Tables[0].AsEnumerable().Select(m => new ContactInformation
                {
                    Name = Convert.ToString(m["ContactName"]),
                    Photo = Convert.ToString(m["ContactPhoto"]),
                    Phone = Convert.ToString(m["ContactPhone"]),
                    Email = Convert.ToString(m["ContactEmail"]),
                    Note = Convert.ToString(m["ContactNote"])
                }).ToList();

            }

            //Build the Business Logic here based on the requirements from the client

            return ContactsList;

        }

    }
}
