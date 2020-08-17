using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class LogConversionParameters : IAlgorithmParameter
    {
        private IDataset dataset;
        public IDataset Dataset
        {
            get { return dataset; }
            set { dataset = value; }
        }

        private int columnIndex;
        public int ColumnIndex
        {
            get { return columnIndex; }
            set { columnIndex = value; }
        }

        private string columnName;
        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        private float _base;
        public float Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public LogConversionParameters(IDataset Dataset, int ColumnIndex, string ColumnName, float Base)
        {
            dataset = Dataset;
            columnIndex = ColumnIndex;
            columnName = ColumnName;
            _base = Base;
        }
    }
}