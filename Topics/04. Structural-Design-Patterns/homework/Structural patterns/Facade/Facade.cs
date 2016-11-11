using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade:IFacade
    {
        private IHomeSystem homeSys = new HomeSystem();
        private IUserManagementSystem users = new UserManagementSystem();
        private IDataProcessor data = new DataProcessor();

        public void Logging(string username, string password)
        {
            homeSys.DisplayHomeScreen();
            users.ConnectToUserDB();
            users.VerifyUserCredentials(username, password);
            data.ConnectToDB();
            Console.WriteLine(data.ProcessData());
        }
    }
}
