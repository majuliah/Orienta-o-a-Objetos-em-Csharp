namespace Cap3._3
{
    public class Calculator
    {

        public static double LetsSum(double[] arraySum)
        {
            double sumResult = 0.0;
            for (int i = 0; i < arraySum.Length; i++)
                sumResult += arraySum[i];
            

            return sumResult;
        }
    }
}