using System;

namespace Cap1._4
{
    public class Triangulo
    {
        public double ladoA, ladoB, ladoC;

        public double CalculoArea()
        {
            double formulaP = (ladoA + ladoB + ladoC) / 2.0;
            double calculoRaiz = Math.Sqrt(formulaP * (formulaP - ladoA) * (formulaP - ladoB) * (formulaP - ladoC) / 2.0);
            return calculoRaiz;
        }
        
    }
}









