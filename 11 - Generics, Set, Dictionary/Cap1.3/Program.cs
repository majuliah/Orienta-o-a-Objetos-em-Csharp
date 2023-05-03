using System;
using Cap1._3.Entities;
using static System.Console;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string a = $"Maria";
            string b = $"Alex";
            string c = $"Maria";
            
            WriteLine(a.Equals(b));
            WriteLine(a.Equals(a));
            
            WriteLine(a.GetHashCode());
            WriteLine(b.GetHashCode());
            WriteLine(c.GetHashCode());
            */

            Client a = new Client() { Name = $"Maria", Email = $"maria@gmail.com" };
            Client b = new Client() { Name = $"Alex", Email = $"alex@gmail.com" };
            Client c = new Client() { Name = $"Carla", Email = $"maria@gmail.com" };
            
            WriteLine(a.Equals(b));
            WriteLine(a.Equals(c));
            WriteLine(a == b); // o == compara referência do ponteiro de memória do objeto -> vai dar diferente pois são diferentes do ponto de vista da referência
            WriteLine(a == c); // uma coisa é comparar referência, outra é comparar conteúdo. 
            WriteLine(a.GetHashCode());
            WriteLine(b.GetHashCode());
            WriteLine(c.GetHashCode());
            
            

        }
    }
}