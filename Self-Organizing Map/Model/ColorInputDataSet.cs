using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    class ColorInputDataSet : InputDataSet
    {
        public ColorInputDataSet(List<InputDataItem> inputDataItems, int inputVectorDimension, int inputDataItemNumber) : base(inputDataItems, inputVectorDimension, inputDataItemNumber) { }

        public static ColorInputDataSet GenerateRandomColorInputDataSet(int inputVectorNumber)
        {
            List<InputDataItem> inputDataItems = new List<InputDataItem>(); 

            for (int i = 0; i < inputVectorNumber; i++)
            {
                inputDataItems.Add(ColorInputDataItem.GenerateRandomColorInputDataItem());
            }

            return new ColorInputDataSet(inputDataItems, ColorInputDataItem.RGB_COLOR_VECTOR_DIMENSION, inputVectorNumber);
        }
    }
}
