﻿using OpenLab.Agilent.cube.dataset;
using OpenLab.Agilent.Spring.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLogN
{
    public class DatasetParameter : IAlgorithmParameter
    {
        public IDataset Dataset { get; set; }
    }
}