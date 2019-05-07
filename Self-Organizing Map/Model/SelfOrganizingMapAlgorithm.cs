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
        public Vector<double> InputVector { get; set; }
        public Neuron BestMatchingUnit { get; set; } = null;

        public void Run(InputDataSet inputDataSet, int NeuralNetworkRows, int NeuralNetworkColumns, int iterationLimit)
        {
            SetParameters(inputDataSet, IterationLimit);
            NeuralNetwork = new NeuralNetwork(NeuralNetworkRows, NeuralNetworkColumns, inputDataSet.InputVectorDimension);

            for (int i = 0; i < IterationLimit; i++)
            {
                InputVector = InputDataSet.SelectRandomInputItem().InputVector;
                CalculateBestMatchingUnit();
                UpdateWeightVectors();
            }
        }

        private void SetParameters(InputDataSet inputDataSet, int iterationLimit)
        {
            InputDataSet = inputDataSet;
            IterationLimit = iterationLimit;
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

        private void CalculateNeighborhoodFunction() { }

        private void LearningRateCoefficient() { }

        private void UpdateWeightVectors()
        {
            foreach (var neuron in NeuralNetwork.Neurons)
            {

            }
        }




    }
}
