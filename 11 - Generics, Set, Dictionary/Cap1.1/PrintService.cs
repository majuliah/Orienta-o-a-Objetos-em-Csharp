using System;
using static System.Console;

namespace Cap1._1
{
    public class PrintService
    {
        private int[] _values = new int[10];
        //var que armazena 10 numeros inteiros

        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException($"PrntService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException($"PrntService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Write($"[");
            for (int i = 0; i < _count - 1; i++)
            {
                Write($"{_values[i]}, ");
            }
            if (_count > 0)
            {
                Write(_values[_count - 1]);
            }
            WriteLine($"]");
        }

    }
}