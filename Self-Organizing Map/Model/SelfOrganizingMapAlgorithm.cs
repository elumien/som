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

        public void Run(InputDataSet inputDataSet, int NeuralNetworkRows, int NeuralNetworkColumns, int iterationLimit)
        {
            SetParameters(inputDataSet, iterationLimit);
            NeuralNetwork = new NeuralNetwork(NeuralNetworkRows, NeuralNetworkColumns, inputDataSet.InputVectorDimension);
        }

        private void SetParameters(InputDataSet inputDataSet, int iterationLimit)
        {
            InputDataSet = inputDataSet;
            IterationLimit = iterationLimit;
        }
    }
}
