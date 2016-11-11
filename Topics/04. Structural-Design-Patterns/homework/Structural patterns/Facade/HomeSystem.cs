using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class HomeSystem:IHomeSystem
    {
        public void DisplayHomeScreen()
        {
            Console.WriteLine("Hello, please login with username and password");
        }
    }
}
