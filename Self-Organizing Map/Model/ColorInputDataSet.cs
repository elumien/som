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

        public static ColorInputDataSet CreateFixColorInputDataSet()
        {
            List<InputDataItem> inputDataItems = new List<InputDataItem>
            {
                new ColorInputDataItem(128, 0, 128),
                new ColorInputDataItem(186, 85, 211),
                new ColorInputDataItem(148, 0, 211),
                new ColorInputDataItem(255, 255, 0),
                new ColorInputDataItem(255, 215, 0),
                new ColorInputDataItem(128, 0, 0),
                new ColorInputDataItem(178, 34, 34),
                new ColorInputDataItem(255, 0, 0)
            };

            return new ColorInputDataSet(inputDataItems, ColorInputDataItem.RGB_COLOR_VECTOR_DIMENSION, 8);
        }
    }
}
