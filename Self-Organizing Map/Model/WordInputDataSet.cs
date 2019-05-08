using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    class WordInputDataSet : InputDataSet
    {
        public WordInputDataSet(List<InputDataItem> inputDataItems, int inputVectorDimension, int inputDataItemNumber) : base(inputDataItems, inputVectorDimension, inputDataItemNumber) { }

        public void vmi()
        {
            List<string> tokenizedText = CreateWordListFromTxt("../../Resource/token.txt");
            List<string> stopWords = CreateWordListFromTxt("../../Resource/stopword.txt");
            List<string> stopWordsFreeText = (List<string>)tokenizedText.Except(stopWords);
        }

        public static List<string> CreateWordListFromTxt(string filePath)
        {
            List<string> wordList = new List<string>();
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var word = reader.ReadLine();
                        wordList.Add(word);
                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return wordList;
        }
    }
}
