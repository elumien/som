using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra;

namespace Self_Organizing_Map.Model
{
    public class ColorInputDataItem : InputDataItem
    {
        public const int RGB_COLOR_VECTOR_DIMENSION = 3;

        public ColorInputDataItem(Vector<double> inputVector) : base(inputVector) { }

        public ColorInputDataItem(double red, double green, double blue) : base(GenerateColorInputVector(red, green, blue)) { }

        private static Vector<double> GenerateColorInputVector(double red, double green, double blue)
        {
            Vector<double> vector = Vector<double>.Build.Dense(RGB_COLOR_VECTOR_DIMENSION);

            vector.SetValues(new double[] { red, green, blue });

            return vector.Normalize(2);
        }

        public static ColorInputDataItem GenerateRandomColorInputDataItem()
        {
            Vector<double> inputVector = Vector<double>.Build.Random(RGB_COLOR_VECTOR_DIMENSION, new ContinuousUniform(0, 1)).Normalize(2); 

            return new ColorInputDataItem(inputVector);
        }
    }
}
