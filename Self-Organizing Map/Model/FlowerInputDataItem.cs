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
        public const int IRIS_FLOWER_VECTOR_DIMENSION = 4;
        public string Species { get; set; }
        public FlowerInputDataItem(Vector<double> inputVector, string Species) : base(inputVector)
        {
            this.Species = Species;
        }
    }
}
