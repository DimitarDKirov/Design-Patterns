using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class UserManagementSystem:IUserManagementSystem
    {
        public bool VerifyUserCredentials(string username, string password)
        {
            Console.WriteLine("User {0} looged in", username);
            return true;
        }

        public void ConnectToUserDB()
        {
            Console.WriteLine("Connect to users DataBase");
        }
    }
}
