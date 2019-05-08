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

        //public const double INITIAL_STANDARD_DEVIATION = 4;
        //public const double FINAL_STANDARD_DEVIATION = 0.5;

        public ColorForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SetCommonParametersFromUserInterface();
            ColorInputDataSet colorInputDataSet = ColorInputDataSet.GenerateRandomColorInputDataSet(COLOR_NUMBER);
            SelfOrganizingMapAlgorithm somAlgorithm = new SelfOrganizingMapAlgorithm();
            somAlgorithm.Run(colorInputDataSet, NEURAL_NETWORK_ROWS, NEURAL_NETWORK_COLUMNS, IterationLimit, InitialStandardDeviation, FinalStandardDeviation, InitialLearningRateCoefficient);
        }


    }
}
