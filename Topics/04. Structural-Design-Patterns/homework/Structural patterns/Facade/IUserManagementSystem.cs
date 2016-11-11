using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    interface IUserManagementSystem
    {
        bool VerifyUserCredentials(string username, string password);

        void ConnectToUserDB();
    }
}