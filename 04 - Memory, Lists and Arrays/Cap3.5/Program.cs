using System;
using static System.Console;

namespace Cap3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("BOXING E UNBOXING: ");

            int boxing = 20;
            //this is in stack

            Object typeOfObject = boxing;
            //this is in heap
            //this is completely possible, because type Object is a generic type and compatible with other types
            //so it can receive int

            int unboxing = (int) typeOfObject;
            //this will receive the value 20 
            //from heap to stack
            
            WriteLine(boxing);
            WriteLine(typeOfObject);
            WriteLine(unboxing);
            




        }
    }
}