using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class LogConversionResult : IAlgorithmResult
    {
        private LogConversionParameters logConversionParameters;
        private LogConversionIn logConversionIn;

        public LogConversionResult(LogConversionParameters logConversionParameters, LogConversionIn logConversionIn)
        {
            this.logConversionParameters = logConversionParameters;
            this.logConversionIn = logConversionIn;
            
            // Validate before getting the result
            this.logConversionIn.Validate();
        }

        public IDataset LogConversion()
        {
            IColumn column = logConversionParameters.Dataset.GetColumn(logConversionParameters.ColumnIndex);

            IColumn newColumn = ColumnOperations.Log(column, logConversionParameters.Base, logConversionParameters.ColumnName);

            logConversionParameters.Dataset.ReplaceColumn(logConversionParameters.ColumnIndex, newColumn);

            return logConversionParameters.Dataset;
        }
    }
}
