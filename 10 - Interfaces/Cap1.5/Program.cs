using System;
using devices;
using static System.Console;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { SerialNumber = 1080965 };
            printer.ProcessDoc($"A letter to elise");
            printer.Print($"A letter to elise");

            Scanner scanner = new Scanner() { SerialNumber = 569872 };
            scanner.ProcessDoc($"My letter");
            WriteLine(scanner.Scan());

            ComboDevice comboDevice = new ComboDevice() { SerialNumber = 354861 };
            comboDevice.ProcessDoc($"My dissertation");
            comboDevice.Print($"Letter to elise");
            WriteLine(comboDevice.Scan());
        }
    }
}