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
            double? temValor = 10.2;
            
            WriteLine(@$"
                        Imprimindo a variável podeNull: {podeNull.Value}
                        Imprimindo a variável temValor: {temValor.Value}
                       ");
            
            WriteLine(@$"
                        Imprimindo a variável podeNull: {podeNull.HasValue}
                        Imprimindo a variável temValor: {temValor.HasValue}
                       ");
            
            WriteLine(@$"
                        Imprimindo a variável podeNull: {podeNull.GetValueOrDefault()}
                        Imprimindo a variável temValor: {temValor.GetValueOrDefault()}
                       ");
            
            
            
            //Operador de coalescência nula:
            //Quer dizer que fazemos uma verificação. Se o valor for
            //nulo, então atribuímos a ele outro valor, dessa forma:

            double? numeroNulo = null;
            double escolheSeEhNulo = numeroNulo ?? 2.3;
            //se o numeroNulo for nullo então a variável escolheseEhNulo 
            //passa a valer 2.3
            
            WriteLine(@$"
                        Imprimindo a variável numeroNulo: {numeroNulo.GetValueOrDefault()}
                        Imprimindo a variável scolheSeEhNulo: {escolheSeEhNulo}
                       ");
        }
    }
}