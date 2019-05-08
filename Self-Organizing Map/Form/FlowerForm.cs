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
    public partial class FlowerForm : BaseForm
    {
        public const int NEURAL_NETWORK_ROWS = 40;
        public const int NEURAL_NETWORK_COLUMNS = 40;

        public FlowerForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            flowerNeuralNetworkControl.Controls.Clear();
            SetCommonParametersFromUserInterface();
            FlowerInputDataSet flowerInputDataSet = FlowerInputDataSet.CreateFlowerInputDataSetFromCvs();
            SomAlgorithm somAlgorithm = new SomAlgorithm();
            NeuralNetwork neuralNetwork = somAlgorithm.Run(flowerInputDataSet, NEURAL_NETWORK_ROWS, NEURAL_NETWORK_COLUMNS, IterationLimit, InitialStandardDeviation, FinalStandardDeviation, InitialLearningRateCoefficient);
            flowerNeuralNetworkControl.SetNeuralNetwork(neuralNetwork);
            flowerNeuralNetworkControl.SetFlowerInputDataSet(flowerInputDataSet);
            flowerNeuralNetworkControl.RefreshMap();
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
