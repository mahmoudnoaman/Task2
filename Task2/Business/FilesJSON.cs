using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Business.Interfaces;
using Task2.Models;
namespace Task2.Business
{
    public class FilesJSON : ExternalDateSource
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
