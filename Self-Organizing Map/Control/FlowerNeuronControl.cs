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
            RefreshNeuron();
        }

        /*public void RefreshNeuron()
        {
            switch (FlowerNeuron.)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }*/
    }
}
