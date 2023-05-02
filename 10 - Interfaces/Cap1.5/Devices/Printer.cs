using System;
using devices;

namespace devices
{
    public class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer processing {document}");
            //implementação do método abstrato da classe Device
        }

        public void Print(string document)
        {
            Console.WriteLine($"Printer print {document}");
            //implementação do método da interface IPrinter
        }
    }
}