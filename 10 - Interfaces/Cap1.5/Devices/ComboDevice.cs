using System;

namespace devices
{
    public class ComboDevice: Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Combo device print {document}");
        }
        
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Combo device print {document}");
        }
        
        public string Scan()
        {
            return $"Combodevice scan result";
        }
    }
}