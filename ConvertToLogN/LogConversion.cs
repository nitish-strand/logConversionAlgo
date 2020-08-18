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

        private DatasetParameter datasetParameter;
        private LogBaseParameter logBaseParameter;

        public LogConversion(IDataset dataset, float baseN)
        {
            datasetParameter = new DatasetParameter();
            logBaseParameter = new LogBaseParameter();

            datasetParameter.Dataset = dataset;
            logBaseParameter.LogBase = baseN;

            LogConversionInput logConversionInput = new LogConversionInput();
            logConversionInput.dataset = datasetParameter;
            logConversionInput.baseN = logBaseParameter;

            Input = logConversionInput;
        }

        public void Execute()
        {
            IDataset newdataset = new Dataset("testDataSet", 5);

            for (int i = 0; i < datasetParameter.Dataset.GetColumnCount(); i++)
            {
                IColumn column = datasetParameter.Dataset.GetColumn(i);
                IColumn newColumn = ColumnOperations.Log(column, logBaseParameter.LogBase, column.GetName());

                newdataset.AddColumn(newColumn);
            }

            DatasetResult datasetResult = new DatasetResult();
            datasetResult.Dataset = newdataset;

            LogConversionOutput logConversionOutput = new LogConversionOutput();
            logConversionOutput.NewDataset = datasetResult;

            Output = logConversionOutput;
        }
    }
}
