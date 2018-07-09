using System;
using System.Collections.Generic;

using Task2.Business.Interfaces;
using Task2.Models;
namespace Task2.Business
{
    public class APINumberOne : ExternalDateSource
    {
       

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool VerifyDateFormat()
        {
            throw new NotImplementedException();
        }
    }
}
