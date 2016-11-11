using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DataProcessor:IDataProcessor
    {

        public void ConnectToDB()
        {
            Console.WriteLine("Connected to DataBase");
        }

        public string ProcessData()
        {
            return "Usefull data";
        }
    }
}
