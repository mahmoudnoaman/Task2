using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Models;
namespace Task2.Business.Interfaces
{
    public interface ExternalDateSource
    {

        List<Product> GetProducts();
        bool VerifyDateFormat();

    }
}
