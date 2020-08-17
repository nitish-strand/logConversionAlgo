using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLab.Agilent.Spring.Algorithm
{
    public interface IAlgorithmInput
    {
        Dictionary<string, IAlgorithmParameter> Parameters { get; set; }

        void Validate(); //Throws exceptions
    }
}
