﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Self_Organizing_Map.Model
{
    class ColorInputDataItem : InputDataItem
    {
        public const int RGB_COLOR_VECTOR_DIMENSION = 3;

        public ColorInputDataItem() : base() { }

        public ColorInputDataItem(Vector<double> vector) : base(vector) { }

        public ColorInputDataItem(double red, double green, double blue) : base(GenerateColorInputVector(red, green, blue)) { }

        private static Vector<double> GenerateColorInputVector(double red, double green, double blue)
        {
            Vector<double> vector = Vector<double>.Build.Dense(RGB_COLOR_VECTOR_DIMENSION);

            vector.SetValues(new double[] { red, green, blue });

            return vector.Normalize(2);
        }

        public static ColorInputDataItem GenerateRandomColorInputDataItem()
        {
            ColorInputDataItem colorInputDataItem = new ColorInputDataItem();

            for (int i = 0; i < RGB_COLOR_VECTOR_DIMENSION; i++)
            {
                colorInputDataItem.InputVector.At(i, random.NextDouble());
            }

            colorInputDataItem.InputVector = colorInputDataItem.InputVector.Normalize(2);

            return colorInputDataItem;
        }
    }
}
