using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    public class SelfOrganizingMapAlgorithm
    {
        public static InputDataSet InputDataSet { get; set; }
        public static NeuralNetwork NeuralNetwork { get; set; }

        public static void Run(InputDataSet inputDataSet, int NeuralNetworkRows, int NeuralNetworkColumns)
        {
            InputDataSet = inputDataSet;
            NeuralNetwork = new NeuralNetwork(NeuralNetworkRows, NeuralNetworkColumns, inputDataSet.InputVectorDimension);

        }
    }
}
