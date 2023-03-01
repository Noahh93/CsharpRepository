using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration.Services
{
    internal interface IProductService
    {
        void TotalProductsAvailable();
        void UpdateProductByID(int productID, string productName, string productDescription, int productQuantity);
        int SubractQuantityByProductID(int productID);
    }
    
}
