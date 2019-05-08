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
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Neuron() { }

        public Neuron(int xCoordinate, int yCoordinate, int vectorDimension)
        {
            WeightVector = Vector<double>.Build.Random(vectorDimension, new ContinuousUniform(0, 1));
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public static double CalculateEuclideanDistance(Neuron neuronA, Neuron neuronB)
        {
            double distance = Math.Sqrt(Math.Pow((neuronA.XCoordinate - neuronB.XCoordinate), 2) + Math.Pow((neuronA.YCoordinate - neuronB.YCoordinate), 2));

            return distance;
        }
    }
}
