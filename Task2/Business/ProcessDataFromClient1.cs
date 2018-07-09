using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Business.Interfaces;
using Task2.Models;
namespace Task2.Business
{
    public class ProcessDataFromClient1
    {
        public void SaveDate()
        {
            try
            {
                Consumer consumer = new Consumer();

                /*
                 * here if i want to consume all types of Data Source i Can add Factory Pattern here as a future enhancement

                 */
                APINumberOne aPINumberOne = new APINumberOne();
                // consumer will accept any Datasource implement ExternalDataSource Interface

                consumer.ProcessData(aPINumberOne);

            }
            catch (Exception)
            {
                // here will be a logger 
                throw;
            }
            

        }

    }
}
