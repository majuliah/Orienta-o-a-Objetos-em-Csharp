using System;
using System.Collections.Generic;
using entities;
using static System.Console;

namespace Cap1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            HashSet<string> hashSet = new HashSet<string>();

            hashSet.Add($"TV");
            hashSet.Add($"Notebook");
            hashSet.Add($"Tablet");
            
            WriteLine(hashSet.Contains($"Notebook"));
            WriteLine(hashSet.Contains($"Computer"));

            foreach (string set in hashSet)
            {
                WriteLine(set);
            }
            */
            
            /*
            SortedSet<int> numbers1 = new SortedSet<int>(){ 0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> numbers2 = new SortedSet<int>(){ 5, 6, 7, 8, 9, 10};
            
            PrintCollection(numbers1);

            //union
            SortedSet<int> numbers3 = new SortedSet<int>(numbers1);
            numbers3.UnionWith(numbers2);
            PrintCollection(numbers3);
            //sortedSet mantém os elementos ordenados

            SortedSet<int> numbers4 = new SortedSet<int>(numbers1);
            numbers4.IntersectWith(numbers2);
            PrintCollection(numbers4);            
            
            //difference
            SortedSet<int> numbers5 = new SortedSet<int>(numbers1);
            numbers5.ExceptWith(numbers2);
            PrintCollection(numbers5);
            */

            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product($"TV", 900));
            products.Add(new Product($"Notebook", 1200));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200);
            WriteLine(products.Contains(prod));
            //embora os dados sejam iguais, o método contains verifica se o prod pertence ao conjunto;
            //comparou as referências dos objetos e não o conteúdo do objeto :D

            Point point2 = new Point(5, 10);
            WriteLine(points.Contains(point2));


        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Write($"{obj} ");
            }
            WriteLine();
        }
    }
}