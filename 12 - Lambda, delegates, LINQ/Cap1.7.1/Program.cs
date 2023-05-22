using System;
using System.Linq;
using static System.Console;

namespace Cap1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //especificar o datasource
            int[] numbers = new int[] { 2, 3, 4, 5 };
            
            //definir a expressão da query
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);
            //coleção que filtra números pares e multiplica eles por 10 e armaena em uma variável result
            
            //executar a consulta
            foreach (int x in result)
            {
                WriteLine(x);
            }
        }
    }
}