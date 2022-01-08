namespace Cap2._3
{
    public class Conta
    {
        private string _nome;
        public string NumeroConta { get; private set; }
        public double ValorNaConta { get; private set; }

        public Conta()
        {
            ValorNaConta = 0;
        }
        
        public Conta(string nome, string numeroConta, double valorNaConta) : this()
        {
            nome = _nome;
            numeroConta = NumeroConta;
        }
        public string Nome
        {
             get { return _nome; }
             set
             {
                 if (value != null && value.Length > 2)
                     _nome = value;
             }
        }
        public void ValorSaque(double valorRetirado)
        {
            ValorNaConta -=  valorRetirado - 5.0;
        }
        
        public void ValorDeposito(double valorAdicionado)
        {
            ValorNaConta += valorAdicionado;
        }
        
        
    }
}