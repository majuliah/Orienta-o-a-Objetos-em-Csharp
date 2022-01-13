using System.Globalization;

namespace Cap2._4
{
    public class ContaBanco
    {
        public string NomeTitular { get; private set; }
        public string NumeroDaConta { get; private set; }
        public double SaldoConta { get; private set; }


        public ContaBanco(string nomeTitular, string numeroDaConta)
        {
            NomeTitular = nomeTitular;
            NumeroDaConta = numeroDaConta;
        }

        public ContaBanco(string nomeTitular, string numeroDaConta, double saldoConta): this(nomeTitular, numeroDaConta)
        {
            SaldoConta = saldoConta;
        }

        public void Saque(double valorSaque)
        {
            SaldoConta -= valorSaque + 1.5;
        }

        public void Deposito(double valorDeposito)
        {
            SaldoConta += valorDeposito;
        }
        
        public override string ToString()
        {
            return ($"{NomeTitular}, aqui estão suas informações: \n " +
                    $"Saldo Atual: {SaldoConta.ToString("F2", CultureInfo.InvariantCulture)} \n");
        }
    }
}