using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class LogConversionInput : IAlgorithmInput 
    {
        public Dictionary<string, IAlgorithmParameter> Parameters { get; set; } = new Dictionary<string, IAlgorithmParameter>();

        public DatasetParameter dataset { get; set; }

        public LogBaseParameter baseN { get; set; }

        public LogConversionInput()
        {
            Parameters.Add("dataset", dataset);
            Parameters.Add("logbase", baseN);
        }

        public void Validate()
        {
            // disputed??? per Input or per parameter????
        }
    }
}
