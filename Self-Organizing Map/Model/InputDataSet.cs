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
        public int InputVectorDimension { get; set; }
        public int InputVectorNumber { get; set; }

        protected InputDataSet(List<InputDataItem> inputDataItems, int inputVectorDimension, int inputVectorNumber)
        {
            InputDataItems = inputDataItems;
            InputVectorDimension = inputVectorDimension;
            InputVectorNumber = inputVectorNumber;
        }

    }
}