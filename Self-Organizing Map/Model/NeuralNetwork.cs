using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Organizing_Map.Model
{
    public class NeuralNetwork
    {
        public Neuron[,] Neurons { get; set; }
        public int Rows { get; }
        public int Columns { get; }
        public int WeightVectorDimension { get; set; }

        public NeuralNetwork(int rows, int columns, int vectorDimension)
        {
            Rows = rows;
            Columns = columns;
            Neurons = new Neuron[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Neurons[i, j] = new Neuron(vectorDimension);
                }
            }
        }
    }
}
