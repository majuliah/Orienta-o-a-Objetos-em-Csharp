using System;
using static System.Console;

namespace Cap1._2
{
    class Program
    {
        public static int globalValue = 3;
        
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
        }

        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}
