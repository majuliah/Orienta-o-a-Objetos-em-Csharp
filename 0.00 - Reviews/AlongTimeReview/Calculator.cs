namespace AlongTimeReview
{
    public class Calculator
    {
        
        public static double Calculinator(params double[] arraySum)
        {
            double sumResult = 0.0;
            for (int i = 0; i < arraySum.Length; i++)
            {
                sumResult += arraySum[i];
            }

            return sumResult;
        }
    }
}