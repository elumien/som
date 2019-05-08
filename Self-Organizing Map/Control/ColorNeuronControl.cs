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
    public partial class ColorNeuronControl : Panel
    {
        public Neuron Neuron { get; set; }

        private const int SIZE = 8;
        private const int SPACING = 1;

        public ColorNeuronControl()
        {
            InitializeComponent();
        }

        public ColorNeuronControl(Neuron neuron)
        {
            Neuron = neuron;
            this.Top = (SIZE + SPACING) * neuron.YCoordinate;
            this.Left = (SIZE + SPACING) * neuron.XCoordinate;
            this.Height = SIZE;
            this.Width = SIZE;
            UpdateColor();
        }

        public void RefreshNeuron()
        {
            UpdateColor();
        }

        public void UpdateColor()
        {
            int red = (int)(Neuron.WeightVector.At(0) * 255);
            int green = (int)(Neuron.WeightVector.At(1) * 255);
            int blue = (int)(Neuron.WeightVector.At(2) * 255);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
