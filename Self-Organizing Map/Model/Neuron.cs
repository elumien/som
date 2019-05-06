using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    public class Neuron
    {
        public Vector<double> WeightVector { get; set; }

        public Neuron(int vectorDimension)
        {
            WeightVector = Vector<double>.Build.Random(vectorDimension, new ContinuousUniform(0, 1));
        }
    }
}
