using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Self_Organizing_Map.Model
{
    class WordInputDataItem : InputDataItem
    {
        public WordInputDataItem(Vector<double> inputVector) : base(inputVector) { }
    }
}
