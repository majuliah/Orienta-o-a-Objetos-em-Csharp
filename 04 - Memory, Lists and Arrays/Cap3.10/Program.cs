using static System.Console;

namespace Cap3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Working with Matrix! \n \n");

            WriteLine($"Enter with the dimension of the matrix");
            int dimensionOfMatrix = int.Parse(ReadLine());
            double[,] myFirstMatrixThisYear = new double[dimensionOfMatrix,dimensionOfMatrix];

            for (int i = 0; i < dimensionOfMatrix; i++)
            { 
                string[] positionsMatrix = ReadLine().Split(' ');
                for (int j = 0; j < dimensionOfMatrix; j++)
                {
                    myFirstMatrixThisYear[i, j] = double.Parse(positionsMatrix[j]);
                }
            }
            
            WriteLine($"Diagonal: ");
            for (int i = 0; i < dimensionOfMatrix; i++)
                WriteLine(myFirstMatrixThisYear[i,i]);
                

            //arrumar a impressão
            for (int i = 0; i < dimensionOfMatrix; i++)
            {
                for (int j = 0; j < dimensionOfMatrix; j++)
                {
                    WriteLine(myFirstMatrixThisYear[i,j] + ' ');
                }
            }
            
            //fazer o contador de números ímpares, números pares, números positivos e negativos
            //fazer o desafio do nelio alves
        }
    }
}