using Self_Organizing_Map.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Organizing_Map.Control
{
    public partial class FlowerNeuralNetworkControl : Panel
    {
        private NeuralNetwork neuralNetwork;
        private FlowerInputDataSet flowerInputDataSet;

        public FlowerNeuralNetworkControl()
        {
            InitializeComponent();
        }

        public NeuralNetwork GetNeuralNetwork()
        {
            return neuralNetwork;
        }

        public FlowerInputDataSet GetFlowerInputDataSet()
        {
            return flowerInputDataSet;
        }

        public void SetFlowerInputDataSet(FlowerInputDataSet value)
        {
            flowerInputDataSet = value;
        }

        private void RefreshMap()
        {
            foreach (InputDataItem inputDataItem in flowerInputDataSet.InputDataItems)
            {
                double euclideanDistanceMinimum = 9999999999999999999;
                Neuron BestMatchingUnit = new Neuron();

                foreach (Neuron neuron in neuralNetwork.Neurons)
                {
                    double distance = MathNet.Numerics.Distance.Euclidean<double>(inputDataItem.InputVector, neuron.WeightVector);

                    if (distance < euclideanDistanceMinimum)
                    {
                        euclideanDistanceMinimum = distance;
                        BestMatchingUnit = neuron;
                    }
                }

                FlowerNeuronControl flowerNeuronControl = new FlowerNeuronControl(BestMatchingUnit, );
            }
        }
    }
}
