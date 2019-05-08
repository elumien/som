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
    public partial class NeuronControl : Panel
    {
        public Neuron Neuron { get; set; }

        public NeuronControl(Neuron neuron)
        {
            InitializeComponent();
            Neuron = neuron;
        }

        virtual public void RefreshNeuron() { }

    }
}
