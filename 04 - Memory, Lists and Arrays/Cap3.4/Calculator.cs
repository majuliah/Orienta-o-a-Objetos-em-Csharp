using System;
namespace Cap3._4
{
    public class Calculator
    {
        public static void Triple( ref int x)
        {
             x *= 3;
        }

        public static void TriplePartTwo(int x, out int result)
        {
            result = x * 3;
        }
        
        
        
        
    }
}