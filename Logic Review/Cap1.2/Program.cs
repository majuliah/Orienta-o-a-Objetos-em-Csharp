using System;
using static System.Console;

namespace Cap1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo pré definido do C#
            sbyte number = 100;
            WriteLine(number);
            
            //Tipo do .NET
            SByte number1 = 100;
            WriteLine(number1);

            byte number2 = 254;
            number2++;
            WriteLine(number2);

            int number3 = 2147483647;
            WriteLine(number3);
            
            //L maiúsculo no final para indicar que estamos manipulando um número LONG
            long number4 = 21474836478L;
            WriteLine(number4);
            
            //valor verdade
            bool happy = true;
            WriteLine(happy);
            
            //um caractere unicode -> char -> aspas simples 
            char dayOrNight = 'D';
            WriteLine(dayOrNight);
            
            //ou em caractere unicode:
            char letterA = '\u0041';
            WriteLine(letterA);
            
            //uma cadeira -> string -> aspas duplas -> cadeia imutável do .NET, forma segura de erros
            string dayOfWeek = "Thursday";
            WriteLine(dayOfWeek);
            
            //float precisa de um f no final
            float numberFloat = 4.5f;
            WriteLine(numberFloat);
            
            //object, toda classe e subclasse em C# é um object
            object obj1 = 452;
            WriteLine(obj1);
            object obj2 = "object aceita qualquer valor";
            WriteLine(obj2);
            
            //pega o menor valor de uma variável, seja ela qual for
            int minimoValor = int.MaxValue;
            WriteLine(minimoValor);
            int maxValue = int.MaxValue;
            WriteLine(maxValue);
            
            sbyte maximo = SByte.MaxValue;
            WriteLine(maximo);
            
            
            //Impressão padrão
            int soma = 1 + 1;
            WriteLine(soma);
            string boa = "Boa Tarde";
            Write(boa);
            
            //Placeholders, Concatenação, Interpolação:
            
            //Placeholder, aloca as variáveis de acordo com as posições. Nome = 0, idade = 1 e saldo = 2
            string nome = "maraju";
            int idade = 25;
            double reais = 25.36;
            WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, reais);
            
            //Interpolação
            WriteLine($"{nome} tem {idade} e o saldo igual a {reais:F2} reais");
            
            //Concatenação
            WriteLine(nome + " tem " + idade + " anos e " + reais);
            
            //Interpolação maior e melhor >>>>
            
            
            //atribuição

            int a = 10;
            a += 2; // 10 + 2
            a -= 2; // 10 - 2
            a *= 2; //10 * 2;
            a /= 2; // 10 / 2;
            a %= 3; // recebe o resto da divisão de a / 3 ( 10 / 3 = 1)

            string s = "ABC";
            s += "DEF";
            WriteLine(s);
            
            //incremento
            a++; // 11 -> pega o valor que já estava e depois faz o incremento
            a--; // 9

            
            int b = 12;
            int c = b++;
            //primeiro ele joga o valor de b na variável c e depois incrementa no c o  +1
            //Na impressão, sairá o resultado
            WriteLine(b + " " + c );

            int d = 10;
            int e = ++d;
            //Primeiro incrementa o valor da variável e depois atribui na variável d
            
            
            //Conversão Implícita e Casting

            float numberer = 4.5f;
            double numberere = numberer;
            WriteLine(numberere);
            //aqui houve uma conversão implícita de float para double
            //se tentarmos fazer o processo inverso, não será possível. Para forçarmos uma conversão, precisamos fazer um casting, dessa forma:

            double num = 5.1;
            float numb = (float) num;
            WriteLine(numb);
            
            //agora uma conversão mais peculiar:
            double aa;
            int bb;

            aa = 5.1;
            bb = (int)aa;
            WriteLine(bb);
            //tivemos perdas de informações

            int A = 5;
            int B = 2;

            double result = A / B;
            WriteLine(result);
            //tivemos perda de informações porque valores inteiros manipulados entre si geram valores inteiros, portando:

            result = (double) A / B;
            WriteLine(result);
            //dessa forma nós conseguimos o resultado quebrado, que é o 2.5
            













        }
    }
}