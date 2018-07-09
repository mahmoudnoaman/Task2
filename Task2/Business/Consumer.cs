using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Business.Interfaces;
using Task2.Models;
namespace Task2.Business
{
    public class Consumer
    {

        public bool ProcessData(ExternalDateSource externalDateSource)
        {


            bool valid = externalDateSource.VerifyDateFormat();
            if (!valid)
            {
                // Data is not in correct format
                return false;
            }
            List<Product> products = externalDateSource.GetProducts();

            // here will be code for handling DataBase Operations


            // Saving Data is Done
            return true;


        }
    }
}
