using System;
using static System.Console;

namespace Cap3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1, p2, p3;
            p1 = new Product("TV", 900, 10);
            
            p2 = p1;
            p3 = null;

            int X = 30;
            int Y = X;
            
            WriteLine("O valor de Y é " + Y);

            
            //Utilizando Structs;

            Point ponto;
            ponto.L = 12;
            ponto.S = 13;
            
            WriteLine(ponto);
            
            // valores nulos

            double naoNulo = null;
            //não pode nulo
            Nullable<double> podeNull = null;
            //uma forma de dizer que a variável do tipo double pode ser null
            double? podeNullTambem = null;
            //o ponto de interrogação deixa a necessidade de entrar com
            //o valor opcional, portanto aceita null


        }
    }
}