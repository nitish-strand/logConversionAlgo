using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class LogConversionOut : IAlgorithmOutput
    {
        public Dictionary<string, IAlgorithmResult> Results { get; set; }

        private LogConversionResult logConversionResult;

        public LogConversionOut(LogConversionResult logConversionResult)
        {
            this.logConversionResult = logConversionResult;

            Results = new Dictionary<string, IAlgorithmResult>()
            {
                {"LogConversionResult", logConversionResult }
            };
        }
    }
}
