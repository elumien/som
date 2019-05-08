using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    public class FlowerInputDataSet : InputDataSet
    {
        public FlowerInputDataSet(List<InputDataItem> inputDataItems, int inputVectorDimension, int inputDataItemNumber) : base(inputDataItems, inputVectorDimension, inputDataItemNumber) { }

        public static FlowerInputDataSet CreateFlowerInputDataSetFromCvs()
        {
            List<InputDataItem> inputDataItems = new List<InputDataItem>();

            Vector<double> vector = Vector<double>.Build.Dense(FlowerInputDataItem.IRIS_FLOWER_VECTOR_DIMENSION);
            try
            {
                using (var reader = new StreamReader("../../Resource/iris.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        double[] vectorComponents = new double[FlowerInputDataItem.IRIS_FLOWER_VECTOR_DIMENSION];

                        for (int i = 0; i < FlowerInputDataItem.IRIS_FLOWER_VECTOR_DIMENSION; i++)
                        {
                            vectorComponents[i] = double.Parse((values[i]), CultureInfo.InvariantCulture);
                        }

                        string vmi = values[4];

                        vector.SetValues(vectorComponents);

                        inputDataItems.Add(new FlowerInputDataItem(vector.Normalize(2), values[FlowerInputDataItem.IRIS_FLOWER_VECTOR_DIMENSION]));
                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return new FlowerInputDataSet(inputDataItems, FlowerInputDataItem.IRIS_FLOWER_VECTOR_DIMENSION, inputDataItems.Count());
        }
    }
}
