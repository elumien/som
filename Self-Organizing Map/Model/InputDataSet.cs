using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    public abstract class InputDataSet
    {
        public List<InputDataItem> InputDataItems { get; set; }
        public int InputDataItemNumber { get; set; }
        public int InputVectorDimension { get; set; }

        private static Random random = new Random();

        public InputDataSet() { }

        public InputDataSet(List<InputDataItem> inputDataItems, int inputVectorDimension, int inputDataItemNumber)
        {
            InputDataItems = inputDataItems;
            InputVectorDimension = inputVectorDimension;
            InputDataItemNumber = inputDataItemNumber;
        }

        public InputDataItem SelectRandomInputItem()
        {
            return InputDataItems.ElementAt(random.Next(InputDataItemNumber));
        }

    }
}