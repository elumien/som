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

        public ColorForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ColorInputDataSet colorInputDataSet = ColorInputDataSet.GenerateRandomColorInputDataSet(COLOR_NUMBER);
            SelfOrganizingMapAlgorithm.Run(colorInputDataSet);
        }
    }
}
