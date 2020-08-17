using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class LogConversion : IAlgorithm
    {
        public IAlgorithmInput Input { get; set; } 
        public IAlgorithmOutput Output { get; set; }

        private IDataset dataset;
        private int columnIndex;
        private string columnName;
        private float _base;

        public LogConversion(IDataset Dataset, int ColumnIndex, string ColumnName, float Base)
        {
            dataset = Dataset;
            columnIndex = ColumnIndex;
            columnName = ColumnName;
            _base = Base;
        }

        public void Execute()
        {
            LogConversionParameters logConversionParameters = new LogConversionParameters(dataset, columnIndex, columnName, _base);
            LogConversionIn logConversionIn = new LogConversionIn(logConversionParameters);

            Input = logConversionIn;

            LogConversionResult logConversionResult = new LogConversionResult(logConversionParameters, logConversionIn);
            logConversionResult.LogConversion();

            LogConversionOut logConversionOut = new LogConversionOut(logConversionResult);

            Output = logConversionOut;

            Console.WriteLine("Dataset is converted. ");
        }
    }
}
