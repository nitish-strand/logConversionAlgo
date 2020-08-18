using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class LogConversionOutput : IAlgorithmOutput
    {
        public Dictionary<string, IAlgorithmResult> Results { get; set; } = new Dictionary<string, IAlgorithmResult>();

        public DatasetResult NewDataset { get; set; }

        public LogConversionOutput()
        {
            Results.Add("dataset", NewDataset);
        }
    }
}
