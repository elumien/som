using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Self_Organizing_Map.Model
{
    class WordInputDataItem : InputDataItem
    {
        public string Word { get; set; }
        public Vector<double> SymbolVector { get; set; }
        public Vector<double> AttributeVector { get; set; }

        public WordInputDataItem(Vector<double> inputVector) : base(inputVector) { }

        public WordInputDataItem(Vector<double> attributeVector, Vector<double> symbolVector, string word)
        {
            Word = word;
            SymbolVector = symbolVector;
            AttributeVector = attributeVector;
            InputVector = Vector<double>.Build.Sparse(WordInputDataSet.REDUCED_DIMENSION * 3);

            for (int i = 0; i < WordInputDataSet.REDUCED_DIMENSION; i++)
            {
                InputVector[i] = symbolVector[i];
            }

            for (int i = WordInputDataSet.REDUCED_DIMENSION; i < 3 * WordInputDataSet.REDUCED_DIMENSION; i++)
            {
                InputVector[i + WordInputDataSet.REDUCED_DIMENSION] = attributeVector[i - WordInputDataSet.REDUCED_DIMENSION];
            }
        }

        public WordInputDataItem(string word, int index)
        {
            Word = word;
            InputVector = Vector<double>.Build.Sparse(WordInputDataSet.VocabularySize);
            InputVector[index] = 1;
            InputVector = WordInputDataSet.MatrixMultiplication(WordInputDataSet.RandomMatrix, InputVector);
        }

        public WordInputDataItem(string word, Vector<double> inputVector)
        {
            Word = word;
            InputVector = inputVector;
        }

        public WordInputDataItem(string word, Vector<double> predecessorVector, Vector<double> successorVector)
        {
            Word = word;
            int dimension = predecessorVector.Count();
            InputVector = Vector<double>.Build.Dense(dimension);

            for (int i = 0; i < dimension; i++)
            {
                InputVector[i] = predecessorVector[i];
            }

            for (int i = dimension; i < 2 * dimension; i++)
            {
                InputVector[i + dimension] = successorVector[i - dimension];
            }
        }

        public WordInputDataItem(List<WordInputDataItem> wordContexts)
        {
            int dimension = wordContexts[0].InputVector.Count;
            Word = wordContexts[0].Word;

            int numberOfContexts = wordContexts.Count();

            double[,] vectors = new double[numberOfContexts, dimension];

            for (int x = 0; x < numberOfContexts; x++)
            {
                Vector<double> currentVector = wordContexts[x].InputVector;

                for (int y = 0; y < dimension; y++)
                {
                    vectors[x, y] = currentVector.At(y);
                }
            }

            InputVector = GetAverageVector(vectors, numberOfContexts, dimension);
        }

        private Vector<double> GetAverageVector(double[,] vectors, int numberOfVectors, int dimension)
        {
            Vector<double> averageVector = Vector<double>.Build.Dense(dimension);
            for (int y = 0; y < dimension; y++)
            {
                double sum = 0;

                for (int x = 0; x < numberOfVectors; x++)
                {
                    sum += vectors[x, y];
                }

                averageVector[y] = sum / numberOfVectors;
            }

            return averageVector;
        }
    }
}
