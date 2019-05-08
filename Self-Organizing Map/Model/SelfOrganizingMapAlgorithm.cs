using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    public class SelfOrganizingMapAlgorithm
    {
        public InputDataSet InputDataSet { get; set; }
        public NeuralNetwork NeuralNetwork { get; set; }
        public int IterationLimit { get; set; }
        public double InitialStandardDeviation { get; set; }
        public double FinalStandardDeviation { get; set; }
        public double InitialLearningRateCoefficient { get; set; }
        public Vector<double> InputVector { get; set; }
        public Neuron BestMatchingUnit { get; set; } = null;

        public void Run(InputDataSet inputDataSet, int NeuralNetworkRows, int NeuralNetworkColumns, int iterationLimit, double initialStandardDeviation, double finalStandardDeviation, double initialLearningRateCoefficient)
        {
            SetParameters(inputDataSet, iterationLimit, initialStandardDeviation, finalStandardDeviation, initialLearningRateCoefficient);
            NeuralNetwork = new NeuralNetwork(NeuralNetworkRows, NeuralNetworkColumns, inputDataSet.InputVectorDimension);

            for (int i = 0; i < IterationLimit; i++)
            {
                InputVector = InputDataSet.SelectRandomInputItem().InputVector;
                CalculateBestMatchingUnit();
                UpdateWeightVectors(i);
            }

            System.Console.WriteLine("Finished");
        }

        private void SetParameters(InputDataSet inputDataSet, int iterationLimit, double initialStandardDeviation, double finalStandardDeviation, double initialLearningRateCoefficient)
        {
            InputDataSet = inputDataSet;
            IterationLimit = iterationLimit;
            InitialStandardDeviation = initialStandardDeviation;
            FinalStandardDeviation = finalStandardDeviation;
            InitialLearningRateCoefficient = initialLearningRateCoefficient;
        }

        private void CalculateBestMatchingUnit()
        {
            double euclideanDistanceMinimum = 9999999999999999999;

            foreach (var neuron in NeuralNetwork.Neurons)
            {
                double distance = MathNet.Numerics.Distance.Euclidean<double>(InputVector, neuron.WeightVector);

                if (distance < euclideanDistanceMinimum)
                {
                    euclideanDistanceMinimum = distance;
                    BestMatchingUnit = neuron;
                }
            }
        }

        private void UpdateWeightVectors(int iteration)
        {
            foreach (var neuron in NeuralNetwork.Neurons)
            {
                Vector<double> inputVector = InputVector;
                neuron.WeightVector = neuron.WeightVector.Add(inputVector.Subtract(neuron.WeightVector).Multiply(CalculateLearningRateCoefficient(iteration)).Multiply(CalculateNeighborhoodFunction(iteration, neuron)));
            }
        }

        private double CalculateStandardDeviation(int iteration)
        {
            return InitialStandardDeviation * Math.Pow(FinalStandardDeviation / InitialStandardDeviation, (double)iteration / (double)IterationLimit);
        }

        private double CalculateLearningRateCoefficient(int iteration)
        {
            return InitialLearningRateCoefficient * (1 - (iteration / IterationLimit));
        }

        private double CalculateNeighborhoodFunction(int iteration, Neuron neuron)
        {
            return Math.Exp(-1 * Math.Pow(Neuron.CalculateEuclideanDistance(BestMatchingUnit, neuron), 2) / Math.Pow(CalculateStandardDeviation(iteration), 2));
        }








    }
}
