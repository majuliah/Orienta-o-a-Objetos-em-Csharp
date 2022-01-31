using System;
using static System.Console;

namespace Cap3._4
{
    class Program
    {
        static void UsingRef()
        {
            WriteLine("Utilizando ref: ");
            
            int a = 10;
            Calculator.Triple(ref a);
            Write(a);
            
            //para que a calculadora funcione, é necessário passar o parâmetro ref antes do valor
            //porque se não colocarmos, o retorno de a não será 30, porque o valor 30 está na heap
            //e o valor 10 na stack. ao imprimirmos o a, pegamos o valor da heap
            //com o ref, fazemos referência à este valor lá
            
            //porém a palavra REF, EXIGE que a variável seja iniciada. Se não passarmos valor para a, ela não
            //terá a que se referir, e não funcionará

        }
        static void Main(string[] args)
        {

            int b = 10;
            Calculator.TriplePartTwo(b, out b);
            WriteLine(b);
            //já o out é uma variável de saída. ele só recebe o valor e não tem a necessidade de 
            //iniciar alguma variável. 
            
            //ambas práticas são desencorajadas, além de ser um recurso para c++

            
            Calculator.Calcular(3,9);
            




        }
    }
}