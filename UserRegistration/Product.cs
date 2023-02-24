using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Product
    {
        private int _id;
        private string _name;
        private string _description;
        private DateTime _createdDateTime;
        private double _price;
        private int _quantity;
        
        public Product(int id, string name, string description, double price, DateTime createdDateTime, int quantity )
        {
            _id = id;
            _name = name;
            _description = description;
            _createdDateTime = createdDateTime;
            _price = price;
            _quantity = quantity;
        }
        public int GetProductID()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public double GetPrice()
        {
            return _price;
        }
        public DateTime GetCreatedDateTime()
        {
            return _createdDateTime;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public bool SetName(string newName)
        {
            _name = newName;
            return true;
        }
        public bool SetDescription(string newDescription)
        {
            _description = newDescription;
            return true;
        }
        public bool SetQuantity(int newQuantity)
        {
            _quantity = newQuantity;
            return true;
        }
    }
}
