using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IFacade facade = new Facade();
            facade.Logging("Misho", "Mishopass");
        }
    }
}
