using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    abstract class InputDataItem
    {
        public Vector<double> InputVector { get; set; }

        public InputDataItem()
        {

        }

        public InputDataItem(Vector<double> inputVector)
        {
            InputVector = inputVector;
        }
    }
}
