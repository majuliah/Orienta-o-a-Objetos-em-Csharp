using System;
using System.Collections.Generic;

namespace Reviews2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation");

            double? x = 10;
            double? y = x ?? 5;

            List<string> nomes = new List<string>(70);
            //para fazer uma lista que recebe dados do banco de dados, deve ser só colocar os tipos do valor, exemplo
            //fazer uma lista com os campos nome, ou uma lista com todos os campos, ainda não sei, veremos heh heh hehh

            foreach (var name in nomes)  
            {
                Console.WriteLine(name);    
            }
            
            
        }
    }
}