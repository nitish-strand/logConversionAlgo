using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLab.Agilent.Spring.Algorithm
{
    public interface IAlgorithm
    {
        IAlgorithmInput Input { get; set; }
        IAlgorithmOutput Output { get; set; }

        void Execute();
    }
}
