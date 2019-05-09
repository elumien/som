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
            SetCommonParametersFromUserInterface();
            ColorInputDataSet colorInputDataSet;
            if (fixColorsRadioButton.Checked)
            {
                colorInputDataSet = CreateExampleColorInputDataSet();
            }
            else
            {
                colorInputDataSet = GenerateRandomColorInputDataSet(COLOR_NUMBER);
            } 
            SomAlgorithm somAlgorithm = new SomAlgorithm();
            somAlgorithm.Run(colorInputDataSet, NEURAL_NETWORK_ROWS, NEURAL_NETWORK_COLUMNS, IterationLimit, InitialStandardDeviation, FinalStandardDeviation, InitialLearningRateCoefficient);
            NeuralNetwork neuralNetwork = somAlgorithm.NeuralNetwork;
            colorNeuralNetworkControl.SetNeuralNetwork(neuralNetwork);
            colorNeuralNetworkControl.RefreshMap();
        }

        private static ColorInputDataSet CreateExampleColorInputDataSet()
        {
            List<InputDataItem> inputDataItems = new List<InputDataItem>
            {
                new ColorInputDataItem(128, 0, 128),
                new ColorInputDataItem(186, 85, 211),
                new ColorInputDataItem(148, 0, 211),
                new ColorInputDataItem(255, 255, 0),
                new ColorInputDataItem(255, 215, 0),
                new ColorInputDataItem(128, 0, 0),
                new ColorInputDataItem(178, 34, 34),
                new ColorInputDataItem(255, 0, 0)
            };

            return new ColorInputDataSet(inputDataItems, ColorInputDataItem.RGB_COLOR_VECTOR_DIMENSION, 8);
        }

        private static ColorInputDataSet GenerateRandomColorInputDataSet(int inputVectorNumber)
        {
            List<InputDataItem> inputDataItems = new List<InputDataItem>();

            for (int i = 0; i < inputVectorNumber; i++)
            {
                inputDataItems.Add(ColorInputDataItem.GenerateRandomColorInputDataItem());
            }

            return new ColorInputDataSet(inputDataItems, ColorInputDataItem.RGB_COLOR_VECTOR_DIMENSION, inputVectorNumber);
        }
    }
}
