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
    public partial class NeuralNetworkControl : Panel
    {
        private NeuralNetwork neuralNetwork;

        public NeuralNetworkControl()
        {
            InitializeComponent();
        }

        public NeuralNetwork GetNeuralNetwork()
        {
            return neuralNetwork;
        }

        public void SetNeuralNetwork(NeuralNetwork value)
        {
            RefreshMap();
            neuralNetwork = value;
        }

        private void RefreshMap()
        {
            foreach (Neuron neuron in neuralNetwork.Neurons)
            {
                NeuronControl neuronControl = new NeuronControl(neuron);
            }
        }
    }
}
