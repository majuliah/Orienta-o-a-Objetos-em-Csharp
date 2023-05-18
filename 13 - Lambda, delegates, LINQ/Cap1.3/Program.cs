using System;
using static System.Console;
using services;

namespace Cap1._3
{
    delegate double BinaryNumericOperation(double n1, double n2);
    //ele é a referência de dois números double e retorna um número double.
    
    
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Intro a delegates");

            double a = 10.0;
            double b = 12.0;

            BinaryNumericOperation operation = CalculationService.Sum;
            //o objeto operations é uma referência para a função

            double firstResult = operation(a, b);
            //podemos chamar o operations aplicando a a e b e teremos o resultado. o delegate operation é uma referência ao método soma

            //meu, isso é lindo demais ✨

            BinaryNumericOperation numericOperation = new BinaryNumericOperation(CalculationService.Max);
            //mesmo que ali em cima, só que mais verboso

            double secondResult = operation.Invoke(a, b);
            //outra sintaxe
            
            double rsult = CalculationService.Sum(a, b);
            WriteLine(rsult);

        }
    }
}