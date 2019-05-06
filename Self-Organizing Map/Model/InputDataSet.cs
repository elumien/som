using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    abstract class InputDataSet
    {
        public List<InputDataItem> InputDataItems { get; set; }

        protected static Random random = new Random();

        public InputDataSet()
        {
        }

        public InputDataSet(List<InputDataItem> inputDataItems)
        {
            InputDataItems = inputDataItems;
        }
    }
}
