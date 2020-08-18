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
            float[] floatArr1 = new float[] { 23.5f, 10.34f, 56.8f, 44.7f, 60.1f };
            float[] floatArr2 = new float[] { 23.5f, 10.34f, 56.8f, 44.7f, 60.1f };

            IColumn Score1 = ColumnFactory.CreateFloatColumn("Score1", floatArr1);
            IColumn Score2 = ColumnFactory.CreateFloatColumn("Score2", floatArr2);

            IColumn[] columns = new IColumn[] { Score1, Score2 };

            IDataset dataset = DatasetFactory.CreateDataset("testDataset", columns, 5);

            LogConversion logConversion = new LogConversion(dataset, 10);
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
