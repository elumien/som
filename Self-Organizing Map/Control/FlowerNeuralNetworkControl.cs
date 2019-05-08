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
        public NeuralNetwork NeuralNetwork { get; set; }
        public FlowerInputDataSet FlowerInputDataSet { get; set; }

        public FlowerNeuralNetworkControl()
        {
            InitializeComponent();
        }

        public void RefreshMap()
        {
            this.Controls.Clear();
            this.BackColor = Color.White;
 
            foreach (FlowerInputDataItem flowerInputDataItem in FlowerInputDataSet.InputDataItems)
            {
                double euclideanDistanceMinimum = 9999999999999999999;
                Neuron BestMatchingUnit = new Neuron();

                System.Console.WriteLine(flowerInputDataItem.Species);

                foreach (Neuron neuron in NeuralNetwork.Neurons)
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
