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

        public WordInputDataItem(Vector<double> inputVector) : base(inputVector) { }

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
                InputVector[i] = successorVector[i - dimension];
            }
        }

    }
}
