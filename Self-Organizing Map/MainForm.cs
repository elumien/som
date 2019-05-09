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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorForm colorForm = new ColorForm();
            colorForm.Show();
        }

        private void FlowerButton_Click(object sender, EventArgs e)
        {
            FlowerForm flowerForm = new FlowerForm();
            flowerForm.Show();
        }
    }
}
