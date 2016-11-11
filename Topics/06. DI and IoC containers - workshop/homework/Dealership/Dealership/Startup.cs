using Dealership.Engine;
using Ninject;
using System;
using System.IO;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(new DealershipModule());

            var dealershipEngine = kernel.Get<IEngine>();
            dealershipEngine.Start();
            //DealershipEngine.Instance.Start();
        }
    }
}
