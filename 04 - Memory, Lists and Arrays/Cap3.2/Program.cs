using System.Globalization;
using static System. Console;

using System.Security.Cryptography;

namespace Cap3._2
{
    class Program
    {
        static void ComoFuncionamArrays()
        {
            //arrays com armazenamento de structs;
            
            WriteLine("Hello World!");
            
            //array é instanciado:
            
            int[] comoFuncionamArrays = new int[10];
            
            //armazenando valores no array:

            int[] armazenandoValores = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //neste caso é obrigatório informar quais são TODOS os elementos que vão dentro dele;
        }
        
        
        static void Main(string[] args)
        {
            //armazenando objetos no array
            //no array do tipo class, nós instanciamos ele como o objeto e depois
            //instanciamos cada objeto referente a posição do array

            Product[] arrayOfObjs = new Product[3];

            for (int i = 0; i < 3; i++)
            {
                WriteLine($"Enter with a name");
                string name = ReadLine();
                WriteLine($"Enter with a price $");
                double value = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                arrayOfObjs[i] = new Product(name, value);
                
            }

            double sum = 0.0;
            
            for (int i = 0; i < 3; i++)
                sum += arrayOfObjs[i].ProductValue;

            double average = sum / 3;
            
            WriteLine(@$"The average of the products is {average.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}