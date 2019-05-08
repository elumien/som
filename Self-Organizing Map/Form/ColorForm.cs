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

namespace Self_Organizing_Map
{
    public partial class ColorForm : BaseForm
    {
        public const int COLOR_NUMBER = 8;
        public const int NEURAL_NETWORK_ROWS = 40;
        public const int NEURAL_NETWORK_COLUMNS = 40;

        public ColorForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            neuralNetworkControl.Controls.Clear();
            SetCommonParametersFromUserInterface();
            ColorInputDataSet colorInputDataSet;
            if (fixColorsRadioButton.Checked)
            {
                colorInputDataSet = ColorInputDataSet.CreateFixColorInputDataSet();
            }
            else
            {
                colorInputDataSet = ColorInputDataSet.GenerateRandomColorInputDataSet(COLOR_NUMBER);
            } 
            SomAlgorithm somAlgorithm = new SomAlgorithm();
            NeuralNetwork neuralNetwork = somAlgorithm.Run(colorInputDataSet, NEURAL_NETWORK_ROWS, NEURAL_NETWORK_COLUMNS, IterationLimit, InitialStandardDeviation, FinalStandardDeviation, InitialLearningRateCoefficient);
            neuralNetworkControl.SetNeuralNetwork(neuralNetwork);
        }

        protected void SetCommonParametersFromUserInterface()
        {
            IterationLimit = (int)iterationLimitNumericUpDown.Value;
            InitialStandardDeviation = (double)initialStandardDeviationNumericUpDown.Value;
            FinalStandardDeviation = (double)finalStandardDeviationNumericUpDown.Value;
            InitialLearningRateCoefficient = (double)initialLearningRateCoefficientNumericUpDown.Value;
        }
    }
}
