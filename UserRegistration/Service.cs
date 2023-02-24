using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration.Services;

namespace UserRegistration
{
    public class Service : IUserService
    {
        private User[] _users;
        private int _index;

        public Service()
        {
            _users = new User[100];
            _index = 0;
        }
        public bool Register(int userId, string name, string email, string password, string country)
        {

            for (int i = 0; i <= _index; i++)
            {
                if (_users[i] != null && _users[i].GetEmail() == email )
                {
                    return false;
                }
            }

            User user = new User(userId, name, email, password, country);

            _users[_index] = user;
            _index++;

            return true;
        }
        public void DisplayUsers()
        {
           for (int i = 0; i < _index; i++)
            {
                User user = _users[i];
                Console.WriteLine($"{user.GetID()},{user.GetName()}, {user.GetEmail()}, {user.GetPassword()}, {user.GetCountry()}");

            }
        }

        public void Login(string email, string password)
        {
            for (int i = 0; i <= _index; i++)
            {
                if (_users[i] != null && _users[i].GetEmail() == email && _users[i].GetPassword() == password)
                {
                    //return _users[i];
                }
                
            }
            //return null;
        }
        public void DisplayTotalUsersByCountry(string country)
        {
            int persons = 0;
            for (int i = 0; i < _index; i++)
            {
                if (_users[i].GetCountry() == country)
                {
                    persons++;
                }
            }
            Console.WriteLine($"We have {persons} users from {country}!");

        }

        public bool ChangePassword(string email, string password)
        {
            for (int i = 0; i < _index; i++)
            {
                if (email == _users[i].GetEmail())
                {
                    _users[i].SetPassword(password);
                }
            }

            return true;
        }
        public bool PurchaseProduct(string productName, int userID)
        {
            for (int i = 0; i < _index; i++)
            {
                if (_users[i].GetID() == userID)
                {
                    _users[i].Booking(productName);
                }
            }
            return true;
        }
        public void DisplayUserOrder(int userID)
        {
            for (int i = 0; i < _index; i++)
            {
                if (_users[i].GetID() == userID)
                {

                    Order[] UserOrders = _users[i].GetUserOrder();
                    for (int j = 0; j < UserOrders.Length; j++)
                    {
                        if (UserOrders[j] == null)
                        {
                            break;
                        }
                        Console.WriteLine($"User name = {_users[i].GetName()}, {UserOrders[j].GetOrderId()}, {UserOrders[j].GetOrderName()}, {UserOrders[j].GetOrderDate()}");
                    }
                }
            }      
        }
        public void DisplayAllUserOrders()
        {
            Console.WriteLine("\n***Following are the users orders***\n");
            for (int i = 0; i < _index; i++)
            {
                Console.WriteLine($"\nUsername:{_users[i].GetName()}");
                Order[] userOrder = _users[i].GetUserOrder();

                for (int j = 0; j < userOrder.Length; j++)
                {
                    if (userOrder[j] == null)
                    {
                        break;
                    }
                    Console.WriteLine($"   OrderID = {userOrder[j].GetOrderId()}, " +
                        $"Ordername = {userOrder[j].GetOrderName()}, " +
                        $"{userOrder[j].GetOrderDate()}");
                        
                }


            }
        }

    }
}
