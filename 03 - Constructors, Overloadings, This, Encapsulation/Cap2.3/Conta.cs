using System.Globalization;

namespace Cap2._3
{
    public class Conta
    {
        public string NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoConta { get; private set; }

        public Conta(string numeroConta, string nomeTitular)
        {
            numeroConta = NumeroConta;
            nomeTitular = NomeTitular;
        }

        public Conta(string nomeTitular, string numeroConta, double saldoConta) : this(numeroConta, nomeTitular)
        {
            SaldoConta = saldoConta;
        }

        public void Saque(double quantia)
        {
            SaldoConta -= quantia + 5.0;
        }

        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta} \n Titular: {NomeTitular}  \n  Saldo Total: {SaldoConta.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}