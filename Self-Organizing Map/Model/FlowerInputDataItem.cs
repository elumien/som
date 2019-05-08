using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Self_Organizing_Map.Model
{
    class FlowerInputDataItem : InputDataItem
    {
        public FlowerInputDataItem(Vector<double> inputVector) : base(inputVector)
        {
        }

        public void csinajjad()
        {

            using (var reader = new StreamReader("Resource/iris.cvs"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }
        }

    }
}
