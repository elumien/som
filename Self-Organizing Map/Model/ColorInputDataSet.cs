using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    class ColorInputDataSet : InputDataSet
    {
        public ColorInputDataSet() : base() { }

        public ColorInputDataSet(List<InputDataItem> inputDataItems) : base(inputDataItems) { }

        public static ColorInputDataSet GenerateRandomColorInputDataSet(int colorNumber)
        {
            ColorInputDataSet colorInputDataSet = new ColorInputDataSet();

            for (int i = 0; i < colorNumber; i++)
            {
                colorInputDataSet.InputDataItems.Add(ColorInputDataItem.GenerateRandomColorInputDataItem());
            }

            return colorInputDataSet;
        }
    }
}
