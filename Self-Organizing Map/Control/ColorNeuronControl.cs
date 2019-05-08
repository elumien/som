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
    public partial class ColorNeuronControl : NeuronControl
    {
        private const int SIZE = 8;
        private const int SPACING = 1;

        public ColorNeuronControl() : base(Neuron)
        {
            InitializeComponent();
        }

        override public void RefreshNeuron()
        {
            UpdateColor();
        }

        public void UpdateColor()
        {
            int red = (int)(Neuron.WeightVector.At(0));
            int green = (int)(Neuron.WeightVector.At(1));
            int blue = (int)(Neuron.WeightVector.At(2));
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
