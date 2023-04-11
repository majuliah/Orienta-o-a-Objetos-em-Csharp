using System;
using System.Collections.Generic;
using Cap1._5.Entities;
using static System.Console;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Abstract class");
            //Funcionario robertoMarinho = new Funcionario();
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            //mesmo sendo abstrata, podemos colocar uma classe como o tipo de uma lista
            
            listaFuncionarios.Add(new Crocheteira($"Maralucia", $"Crocheteira", $"Amigurumis", 2000.00));
            listaFuncionarios.Add(new Crocheteira($"Mara", $"Crocheteira", $"Bolsas", 5000.00));
            listaFuncionarios.Add(new Designer($"Bay",$"Designer" ,$"Interiores", 6000.00, $"Blender"));
            listaFuncionarios.Add(new Designer($"Oncé",$"Designer" ,$"Exteriores", 5000.00, $"Blender"));
            
        }
    }
}