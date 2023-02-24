using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration.Services
{
    internal interface IUserService
    {
        void DisplayTotalUsersByCountry(string country);
        bool ChangePassword(string email, string password);
        void DisplayUserOrder(int userID);
        void DisplayAllUserOrders();
    }
}
