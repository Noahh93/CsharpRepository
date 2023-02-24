using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Order
    {
        private int _orderID;
        private string _orderName;
        private DateTime _orderDate;
        private Product[] _products; 
        

        public Order(int orderID, string orderName, DateTime orderDate)
        {
            _orderID = orderID;
            _orderName = orderName;
            _orderDate = orderDate;
            _products = new Product[1000];
        }
        public int GetOrderId()
        {
            return _orderID;
        }
        public string GetOrderName()
        {
            return _orderName;
        }
        public DateTime GetOrderDate()
        {
            return _orderDate;
        }
    }
}
