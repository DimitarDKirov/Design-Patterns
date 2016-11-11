using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Engine
{
    public class InputOutputProvider : IInputOutputProvider
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string line)
        {
            Console.WriteLine(line);
        }
    }
}
