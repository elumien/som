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
    public partial class FlowerNeuronControl : Panel
    {
        public Neuron Neuron { get; set; }

        private const int SIZE = 8;
        private const int SPACING = 1;

        public FlowerNeuronControl()
        {
            InitializeComponent();
        }

        public FlowerNeuronControl(Neuron neuron, String species)
        {
            Neuron = neuron;
            this.Top = (SIZE + SPACING) * neuron.YCoordinate;
            this.Left = (SIZE + SPACING) * neuron.XCoordinate;
            this.Height = SIZE;
            this.Width = SIZE;
            RefreshNeuron(species);
        }

        public void RefreshNeuron(String species)
        {
            switch (species)
            {
                case "setosa":
                    this.BackColor = Color.Red;
                    break;
                case "versicolor":
                    this.BackColor = Color.Green;
                    break;
                case "virginica":
                    this.BackColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }
    }
}
