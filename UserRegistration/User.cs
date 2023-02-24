using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class User
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _country;
        private Order[] _orders;
        private int _index;

        public User(int id, string name, string email, string password, string country)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _country = country;
            _orders = new Order[1000];
            _index = 0;
        }
        public string GetEmail() 
        {
            return _email;
        }
        public int GetID() 
        {
            return _id; 
        }
        public string GetName() 
        {
            return _name; 
        }
        public string GetPassword()
        {
            return _password;
        }
        public string GetCountry()
        {
            return _country;
        }
        public Order[] GetUserOrder()
        {
            return _orders;
        }
        public void SetPassword(string password)
        {
            _password = password;
        }
        public bool Booking(string ProdName)
        {
            Order order = new Order(_index + 1, ProdName, DateTime.Now);
            _orders[_index] = order;
            _index++;
            return true;

        }

    }
}
