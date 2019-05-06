using Self_Organizing_Map.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Organizing_Map
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Neuron n = new Neuron(3);
            ColorInputDataItem.GenerateRandomColorInputDataItem();
            //Application.Run(new MainForm());
        }
    }
}
