using System;

namespace Cap3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Matrix!");
            double[,] firstMatrix = new double[3, 3];
            Console.WriteLine($"Matrix length {firstMatrix.Length}");
            Console.WriteLine($"Matrix rank {firstMatrix.Rank}");
            //return first dimension of Matrix
            Console.WriteLine($"Matrix Get Length {firstMatrix.GetLongLength(0)}");
            //returns the length of the first dimension of the matrix
            //the parameter passed is the dimension you want to know the length
            Console.WriteLine($"Matrix Get Lenght {firstMatrix.GetLength(1)}");
            //will return the size of second dimension, (at position 1)
            
        }
    }
}