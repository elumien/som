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
    public partial class WordForm : BaseForm
    {
        public WordForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            WordInputDataSet wordInputDataSet = new WordInputDataSet(null, 0, 0);
            wordInputDataSet.ProcessText();

        }
    }
}
