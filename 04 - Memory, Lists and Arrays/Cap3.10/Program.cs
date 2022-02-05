using System.Globalization;
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
                    myFirstMatrixThisYear[i, j] = double.Parse(positionsMatrix[j], CultureInfo.InvariantCulture);
                }
            }
            
            WriteLine($"Diagonal:  \n \n");
            for (int i = 0; i < dimensionOfMatrix; i++)
                WriteLine(myFirstMatrixThisYear[i,i]);
                
            WriteLine($"________________________________ \n \n");
            
            for (int i = 0; i < dimensionOfMatrix; i++)
            {
                for (int j = 0; j < dimensionOfMatrix; j++)
                    Write(myFirstMatrixThisYear[i,j] + " ");
                WriteLine(" ");
            }

            int totalNegative = 0, totalPositive = 0, totalPair = 0, totalOdd = 0;
            for (int i = 0; i < dimensionOfMatrix; i++)
            {
                for (int j = 0; j < dimensionOfMatrix; j++)
                {
                    if (myFirstMatrixThisYear[i,j] > 0)
                        totalNegative += 1;
                    else
                        totalNegative += 1;
                    
                    if (myFirstMatrixThisYear[i, j] % 2 == 0)
                        totalPair += 1;
                    else
                        totalOdd += 1;
                }
            }
            
            WriteLine($"Total pair: {totalPair}, total odd: {totalOdd}, total negative: {totalNegative}, total positive: {totalPositive}");
        }
    }
}