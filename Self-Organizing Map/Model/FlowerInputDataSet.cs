using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    class FlowerInputDataSet : InputDataSet
    {
        public FlowerInputDataSet(List<InputDataItem> inputDataItems, int inputVectorDimension, int inputDataItemNumber) : base(inputDataItems, inputVectorDimension, inputDataItemNumber)
        {

        }

        public void ReadCVS()
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
