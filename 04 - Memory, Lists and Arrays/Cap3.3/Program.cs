using static System.Console;

namespace Cap3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Using params modifier");
            WriteLine($"Using methods with array as params for calculate the sum of some random numbers");
            
            double firstWay = Calculator.LetsSum(new double[] {12, 32, 45, 59});
            double firstWayAddingNumbers = Calculator.LetsSum(new double[] {62, 78, 36, 29, 81, 44, 78});
            
            WriteLine(@$"The result of the first way to do, but only with 4 numbers
                         in sum is {firstWay} and with more numbers is {firstWayAddingNumbers}");
            
            
            //the code works... but... we can do better and cleaner, right? instance the array
            //turn things complicated and bad looking (the code is polluted)
            
            double secondWay = Calculator.LetsSum(2, 3, 4, 5);
            double secondWayAddingNumbers = Calculator.LetsSum(6, 8, 3, 9, 8, 4, 7);
            
            WriteLine(@$"The result of the second way to do, but only with 4 numbers
                         in sum is {secondWay} and with more numbers is {secondWayAddingNumbers}");


        }
    }
}