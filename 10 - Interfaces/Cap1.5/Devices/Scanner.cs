using System;

namespace devices
{
    public class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Scanner processing {document}");
            //implementação da superclasse Device
        }

        public string Scan()
        {
            return $"Scanner scan result";
            //implementação da interface IScanner
        }
    }
}