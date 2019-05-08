using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    class FlowerInputDataSet : InputDataSet
    {
        public FlowerInputDataSet(List<InputDataItem> inputDataItems, int inputVectorDimension, int inputDataItemNumber) : base(inputDataItems, inputVectorDimension, inputDataItemNumber)
        {

        }

        public static FlowerInputDataSet CreateFlowerInputDataSetFromCvs()
        {
            List<InputDataItem> inputDataItems = new List<InputDataItem>();

            Vector<double> vector = Vector<double>.Build.Dense(FlowerInputDataItem.IRIS_FLOWER_VECTOR_DIMENSION);
            using (var reader = new StreamReader("Resource/iris.cvs"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    for (int i = 0; i < 4; i++)
                    {
                        vector.Add(Convert.ToDouble(values[i]));
                    }

                    inputDataItems.Add(new FlowerInputDataItem(vector, values[4].ToString()));
                }
            }

            return new FlowerInputDataSet(inputDataItems, FlowerInputDataItem.IRIS_FLOWER_VECTOR_DIMENSION, inputDataItems.Count());
        }
    }
}
