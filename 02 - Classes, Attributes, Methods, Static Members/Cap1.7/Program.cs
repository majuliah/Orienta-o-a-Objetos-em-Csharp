using System;
using System.Globalization;
using static System.Console;

namespace Cap1._7
{
    class Program
    {
        static double PI = 3.14;
        static void Main(string[] args)
        {
            WriteLine("Entre com o valor do raio: ");
            double raioP = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double circun = Circunferencia(raioP);
            double volume = Volume(raioP);
            WriteLine($"A circunferência é: {circun.ToString("F2", CultureInfo.InvariantCulture)}  \n " +
                      $"O volume é {volume.ToString("F2", CultureInfo.InvariantCulture)} \n");

        }
        //Agora criaremos uma função para calcular a circunferÊncia e o volume do raio;
        static double Circunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }
        static double Volume(double raio)
        {
            return 4.0 / 3.0 * PI * Math.Pow(raio, 3.0);
        }
        
    }
}