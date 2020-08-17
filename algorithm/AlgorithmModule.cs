using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;

namespace OpenLab.Agilent.Spring.Algorithm
{
    class AlgorithmModule : IModule
    {

        IUnityContainer container;

        public AlgorithmModule(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            this.container.RegisterType<IAlgorithm, AlgoA>();
        }
    }
}
