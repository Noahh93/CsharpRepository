using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration.Services
{
    public class ProductService : IProductService
    {
        private Product[] _products;
        int _index;
        public ProductService()
        {
            _products = new Product[250];
            _index = 0;
        }
        public bool RegisterProduct(int productID, string productName, string productDescription, double price, DateTime createdDate, int quantity)
        {

            Product item = new Product(productID, productName, productDescription, price, createdDate, quantity);
            _products[_index] = item;
            _index++;

            return true;
        }
        public void DisplayProduct()
        {
            Product obj1 = _products[0];
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i] == null)
                {
                    break;
                }
                Console.WriteLine($"\n{_products[i].GetProductID()}, \nName: {_products[i].GetName()}, \n{_products[i].GetDescription()},\nPrice: {_products[i].GetPrice()}, \n{_products[i].GetCreatedDateTime()}, \nIn stock: {_products[i].GetQuantity()}");
                
            }
        }
        
        public void DisplayHighestPriceProduct()
        {
            Product MAXproduct = _products[0]; 
            for (int i = 1; i < _index; i++)
            {
                if (MAXproduct.GetPrice() < _products[i].GetPrice())
                {
                    MAXproduct = _products[i];
                }  
            }
            Console.WriteLine($"\nThe highest priced product is = {MAXproduct.GetProductID()},\n{MAXproduct.GetPrice()},\n{MAXproduct.GetName()},\n{MAXproduct.GetDescription()},\n{MAXproduct.GetCreatedDateTime()}");
        }
        public void TotalProductsAvailable()
        {

            int howMany = 0;
            for (int i = 0; i < _index; i++)
            {
                howMany++;
            }

            int productQuantity = 0;

            for (int i = 0; i < howMany; i++)
            {
                productQuantity = productQuantity + _products[i].GetQuantity();
            }
            
            Console.WriteLine("We have " + howMany + " different products in store. With the quantity of " + productQuantity + " in total");
        }
        public void UpdateProductByID(int productID, string NewProductName, string NewProductDescription, int NewProductQuantity)
        {
            if (productID > 0 || NewProductName != null || NewProductDescription != null || NewProductQuantity > 0)
            {
                for (int i = 0; i < _index - 1; i++)
                {
                    if (productID == _products[i].GetProductID())
                    {
                        if (NewProductName != null)
                        {
                            _products[i].SetName(NewProductName);
                        }
                        if (NewProductDescription != null)
                        {
                            _products[i].SetDescription(NewProductDescription);
                        }
                        if (NewProductQuantity > 0)
                        {
                            _products[i].SetQuantity(NewProductQuantity);
                        }
                        break;
                    }
                }
            }
        }
        public int SubractQuantityByProductID(int productID)
        {
            int latestQuantity = 0;
            for (int i = 0; i < _index; i++)
            {

                if (productID == _products[i].GetProductID())
                {
                    int quantity = _products[i].GetQuantity();
                    if (quantity > 0)
                    {
                        latestQuantity = quantity - 1;
                        _products[i].SetQuantity(latestQuantity);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return latestQuantity;
        }
    }
}
