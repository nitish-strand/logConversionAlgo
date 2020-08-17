using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenLab.Agilent.Spring.Algorithm
{
    class AlgorithmEngine
    {
        IUnityContainer container;

        public AlgorithmEngine(IUnityContainer container)
        {
            this.container = container;
        }

        public void Execute(string algorithmId)
        {
            IAlgorithm algorithm = this.container.Resolve<IAlgorithm>();
            algorithm.Execute();

        }
    }
}
