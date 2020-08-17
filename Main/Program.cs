using ConvertToLogN;
using OpenLab.Agilent.cube.dataset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = new string[] { "GENESPRING", "STRANDLIFESCIENCES", "BIOINFORMATICS", "SOFTWAREDEVELOPMENT", "GENOMICMED" };
            float[] floatArr = new float[] { 23.5f, 10.34f, 56.8f, 44.7f, 60.1f };

            IColumn TeamName = ColumnFactory.CreateStringColumn("Name", stringArr);
            IColumn Score = ColumnFactory.CreateFloatColumn("Score", floatArr);

            IColumn[] columns = new IColumn[] { TeamName, Score };

            IDataset dataset = DatasetFactory.CreateDataset("testDataset", columns, 5);

            LogConversion logConversion = new LogConversion(dataset, 1, "Score", 10);
            logConversion.Execute();


            for (int i = 0; i < dataset.GetRowCount(); i++)
            {
                var val1 = dataset.GetColumn(0).Get(i);
                var val2 = dataset.GetColumn(1).Get(i);
                Console.WriteLine("{0}  \t   {1} ",val1,val2);
            }

            Console.ReadKey();
        }
    }
}
