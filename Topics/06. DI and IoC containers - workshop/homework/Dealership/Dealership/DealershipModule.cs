using Dealership.Engine;
using Dealership.Factories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class DealershipModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();
            this.Bind<IDealershipFactory>().To<DealershipFactory>();
            this.Bind<IInputOutputProvider>().To<InputOutputProvider>();
        }
    }
}
