using System;
using System.Collections.Generic;
using static System.Console;

namespace Cap1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            
            // no dictionary você informa o tipo da chave e o tipo do valor:
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            //a variável que recebeu o cookie e dentro dos colchetes possui o nome da chave
            cookies[$"user"] = $"majulia";
            cookies[$"email"] = $"majulia@gmail.com";
            cookies[$"phone"] = $"5465533543";
            cookies[$"phone"] = $"4884648646";
            WriteLine(cookies[$"phone"]);
            WriteLine(cookies[$"email"]);

            cookies.Remove($"email");

            if (cookies.ContainsKey($"email"))
            {
                WriteLine(cookies[$"email"]);
            }
            else
            {
                WriteLine($"There is no such key.");
            }
            
            WriteLine($"Size: {cookies.Count}");

            foreach (KeyValuePair<string, string> item in cookies)
            {
                WriteLine($"{item.Key} : {item.Value}");
            }            
            
            foreach (var item in cookies)
            {
                WriteLine($"{item.Key} : {item.Value}");
            }
            
        }
    }
}