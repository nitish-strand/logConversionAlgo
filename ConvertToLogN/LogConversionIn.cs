using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class LogConversionIn : IAlgorithmInput
    {
        public Dictionary<string, IAlgorithmParameter> Parameters { get; set; }

        private LogConversionParameters logAlgorithmParameter;

        public LogConversionIn(LogConversionParameters logAlgorithmParameter)
        {
            Parameters = new Dictionary<string, IAlgorithmParameter>()
             {
                 {"LogConversionParameter", logAlgorithmParameter }
             };

            this.logAlgorithmParameter = logAlgorithmParameter;
        }

        public void Validate()
        {
            if(!(logAlgorithmParameter.Dataset.GetType() == typeof(Dataset)))
            {
                throw new Exception("Not a dataset");
            }

            if(logAlgorithmParameter.Base < 0)
            {
                throw new Exception("Not a valid log base, or log 0 is undefined");
            }

            if (logAlgorithmParameter.Dataset.GetColumnCount() <= 0)
            {
                throw new Exception("Empty dataset not valid");
            }

            if(!(logAlgorithmParameter.Dataset.GetColumnName(logAlgorithmParameter.ColumnIndex) == logAlgorithmParameter.ColumnName))
            {
                throw new Exception("Enter valid ColumnName & ColumnIndex");
            }
        }
    }
}
