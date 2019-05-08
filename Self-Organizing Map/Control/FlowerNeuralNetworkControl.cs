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

        public void SetNeuralNetwork(NeuralNetwork value)
        {
            neuralNetwork = value;
        }

        public FlowerInputDataSet GetFlowerInputDataSet()
        {
            return flowerInputDataSet;
        }

        public void SetFlowerInputDataSet(FlowerInputDataSet value)
        {
            flowerInputDataSet = value;
        }

        public void RefreshMap()
        {
            this.BackColor = Color.White;
 
            foreach (FlowerInputDataItem flowerInputDataItem in flowerInputDataSet.InputDataItems)
            {
                double euclideanDistanceMinimum = 9999999999999999999;
                Neuron BestMatchingUnit = new Neuron();

                System.Console.WriteLine(flowerInputDataItem.Species);

                foreach (Neuron neuron in neuralNetwork.Neurons)
                {
                    double distance = MathNet.Numerics.Distance.Euclidean<double>(flowerInputDataItem.InputVector, neuron.WeightVector);

                    if (distance < euclideanDistanceMinimum)
                    {
                        euclideanDistanceMinimum = distance;
                        BestMatchingUnit = neuron;

                        System.Console.WriteLine(BestMatchingUnit.XCoordinate + "    " + BestMatchingUnit.YCoordinate);
                    }
                }

                this.Controls.Add(new FlowerNeuronControl(BestMatchingUnit, flowerInputDataItem.Species));


            }
        }
    }
}
