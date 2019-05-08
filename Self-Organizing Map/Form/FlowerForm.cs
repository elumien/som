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
        public FlowerForm()
        {
            InitializeComponent();
            FlowerInputDataSet flowerInputDataSet = FlowerInputDataSet.CreateFlowerInputDataSetFromCvs();

            foreach (InputDataItem inputDataItem in flowerInputDataSet.InputDataItems)
            {
                System.Console.WriteLine(inputDataItem.InputVector.ToVectorString());
                System.Console.WriteLine(flo
            }
        }
    }
}
