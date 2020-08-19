using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLab.Agilent.Spring.Algorithm.ConvertToLogN
{
    public class DatasetResult : IAlgorithmResult
    {
        public IDataset Dataset { get; set; }
        public DatasetResult(IDataset dataset)
        {
            Dataset = dataset;
        }
    }
}
