using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLab.Agilent.Spring.Algorithm.ConvertToLogN
{
    public class LogBaseParameter : IAlgorithmParameter
    {
        public float LogBase { get; set; }
        public LogBaseParameter(float baseN)
        {
            LogBase = baseN;
        }
    }
}
