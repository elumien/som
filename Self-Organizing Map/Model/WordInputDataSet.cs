using MathNet.Numerics.LinearAlgebra;
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
        public static int VocabularySize { get; set; }
        public const int MOST_FREQUENT_WORD_NUMBER = 15;
        public const int REDUCED_DIMENSION = 60;
        public static double[,] RandomMatrix { get; set; }

        private static Random random = new Random();

        public WordInputDataSet(List<WordInputDataItem> wordInputDataItem, int inputVectorDimension, int inputDataItemNumber) { }

        public WordInputDataSet ProcessText()
        {
            List<string> tokenizedText = CreateWordListFromTxt("../../Resource/token.txt");
            List<string> stopWords = CreateWordListFromTxt("../../Resource/stopword.txt");
            IEnumerable<string> stopWordsFreeTextEnumerable = tokenizedText.Except(stopWords);
            List<string> stopWordsFreeText = stopWordsFreeTextEnumerable.ToList<string>();
            IEnumerable<string> distinctWordsEnumerable = stopWordsFreeText.Distinct<string>();
            List<string> distinctWords = distinctWordsEnumerable.ToList<string>();
            List<string> mostFrequentWords = GetMostFrequentWords(stopWordsFreeText, MOST_FREQUENT_WORD_NUMBER);
            VocabularySize = distinctWords.Count();
            CreateRandomMatrix(VocabularySize, REDUCED_DIMENSION);
            List<WordInputDataItem> symbolCodes = CreateSymbolCodes(distinctWords);
            List<WordInputDataItem> contexts = CreateAttributeFields(stopWordsFreeText, symbolCodes, mostFrequentWords);
            List<WordInputDataItem> averageContexts = CalculateAverageAttributeFields(symbolCodes, contexts, mostFrequentWords);
            System.Console.WriteLine("VÉÉÉÉÉÉÉÉGE" + VocabularySize);
            List<WordInputDataItem> wordInputDataItem = CreateInput(symbolCodes, averageContexts);

            return new WordInputDataSet(wordInputDataItem, REDUCED_DIMENSION * 3, wordInputDataItem.Count);

        }

        public List<WordInputDataItem> CreateInput(List<WordInputDataItem> symbolCodes, List<WordInputDataItem> averageContext)
        {
            int numberOfWords = averageContext.Count();
            string word;

            List<WordInputDataItem> Inputs = new List<WordInputDataItem>(numberOfWords);

            for (int i = 0; i < numberOfWords; i++)
            {
                Vector<double> attributes = averageContext[i].InputVector;
                word = averageContext[i].Word;
                Vector<double> symbol = symbolCodes.Where(w => w.Word == word).First().InputVector;
                Inputs.Add(new WordInputDataItem(symbol, attributes, word));
            }
            return Inputs;

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

        public List<string> GetMostFrequentWords(List<string> words, int number)
        {
            var wordFrequency = words.GroupBy(w => w).OrderByDescending(g => g.Count());

            List<string> mostFrequentWords = new List<string>();
            int index = 0;
            foreach (var word in wordFrequency)
            {
                if (index < number)
                {
                    mostFrequentWords.Add(word.ToString());
                    index++;
                }
                else { break; }
            }
            return mostFrequentWords;
        }

        public static void CreateRandomMatrix(int dimension, int reducedDimension)
        {
            RandomMatrix = new double[reducedDimension, dimension];

            for (int x = 0; x < reducedDimension; x++)
            {
                Vector<double> unitVector = Vector<double>.Build.Dense(dimension);

                for (int z = 0; z < dimension; z++)
                {
                    unitVector[z] = random.NextDouble();
                }

                unitVector.Normalize(2);

                for (int y = 0; y < dimension; y++)
                {
                    RandomMatrix[x, y] = unitVector[y];
                }
            }
        }

        public static Vector<double> MatrixMultiplication(double[,] randomMatrix, Vector<double> simpleVector)
        {
            int reducedDimension = randomMatrix.GetLength(0);
            int dimension = randomMatrix.GetLength(1);

            Vector<double> reducedDimensionVector = Vector<double>.Build.Dense(reducedDimension);

            for (int x = 0; x < reducedDimension; x++)
            {
                { reducedDimensionVector[x] = 0; }

                for (int y = 0; y < dimension; y++)
                {
                    reducedDimensionVector[x] += randomMatrix[x, y] * simpleVector[y];
                }
            }
            return reducedDimensionVector;
        }

        private static List<WordInputDataItem> CreateSymbolCodes(List<string> distinctWords)
        {
            List<WordInputDataItem> symbolCodes = new List<WordInputDataItem>();
            int index = 0;
            foreach (string word in distinctWords)
            {
                WordInputDataItem wordInputDataItem = new WordInputDataItem(word, index);
                symbolCodes.Add(wordInputDataItem);
                index++;
            }
            return symbolCodes;
        }

        public List<WordInputDataItem> CreateAttributeFields(List<string> words, List<WordInputDataItem> symbolCodes, List<string> mostFrequentWords)
        {
            int numberOfWords = words.Count();

            List<WordInputDataItem> contextsList = new List<WordInputDataItem>();

            for (int i = 1; i < numberOfWords - 1; i++)
            {
                if (mostFrequentWords.Where(w => w == words[i]).Count() != 0)
                {
                    string prewWord = words[i - 1];
                    string currWord = words[i];
                    string succrWord = words[i + 1];

                    WordInputDataItem currentWord = symbolCodes.Where(w => w.Word == currWord).First();
                    WordInputDataItem predecessorWord = symbolCodes.Where(w => w.Word == prewWord).First();
                    WordInputDataItem successorWord = symbolCodes.Where(w => w.Word == succrWord).First();

                    WordInputDataItem wordInputDataItem = new WordInputDataItem(words[i], predecessorWord.InputVector, successorWord.InputVector);

                    contextsList.Add(wordInputDataItem);
                }
            }
            return contextsList;
        }

        private List<WordInputDataItem> CalculateAverageAttributeFields(List<WordInputDataItem> symbolCodes, List<WordInputDataItem> contexts, List<string> mostFrequentWords)
        {
            int numberOfTopWords = mostFrequentWords.Count;
            int numberOfDistinctWords = symbolCodes.Count();

            List<WordInputDataItem> averageContexts = new List<WordInputDataItem>(numberOfTopWords);

            string word;
            int index = 0;

            for (int i = 0; i < numberOfDistinctWords; i++)
            {
                word = symbolCodes[i].Word;

                int wordcount = mostFrequentWords.Where(w => w == word).Count();
                if (wordcount != 0)
                {
                    List<WordInputDataItem> wordContexts = contexts.Where(w => w.Word == word).ToList<WordInputDataItem>();
                    averageContexts[index] = new WordInputDataItem(wordContexts);
                    index++;
                }
            }
            return averageContexts;

        }
    }
}
