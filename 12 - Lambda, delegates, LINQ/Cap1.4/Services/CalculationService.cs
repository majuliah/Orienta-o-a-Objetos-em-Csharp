using static System.Console;
namespace services
{
    public class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            WriteLine(max);
        }
        
        public static void ShowSum(double x, double y)
        {
            double sum =  x + y;
            WriteLine(sum);
        }
        
        
    }
}