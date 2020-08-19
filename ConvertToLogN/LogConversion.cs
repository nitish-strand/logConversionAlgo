using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLab.Agilent.Spring.Algorithm.ConvertToLogN
{
    public class LogConversion : IAlgorithm
    {
        public IAlgorithmInput Input { get; set; }
        public IAlgorithmOutput Output { get; set; }

        private DatasetParameter datasetParameter;
        private LogBaseParameter logBaseParameter;

        public LogConversion(LogConversionInput logConversionInput)
        {
            Input = logConversionInput;
        }

        public void Execute()
        {
            //Validate AlgorithmParameter individually || Validate in AlgorithmInput

            IDataset newDataset = new Dataset("testDataSet", 5);

            datasetParameter = (DatasetParameter)Input.Parameters["dataset"];
            logBaseParameter = (LogBaseParameter)Input.Parameters["logbase"];

            for (int i = 0; i < datasetParameter.Dataset.GetColumnCount(); i++)
            {
                IColumn column = datasetParameter.Dataset.GetColumn(i);
                IColumn newColumn = ColumnOperations.Log(column, logBaseParameter.LogBase, column.GetName());

                newDataset.AddColumn(newColumn);
            }

            UpdateOutput(newDataset);
        }

        public void UpdateOutput(IDataset newDataset)
        {
            LogConversionOutput logConversionOutput = new LogConversionOutput(newDataset);
            Output = logConversionOutput;
        }
    }
}
