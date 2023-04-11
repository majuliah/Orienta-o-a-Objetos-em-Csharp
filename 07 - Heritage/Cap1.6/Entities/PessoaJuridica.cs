namespace Cap1._6.Entities
{
    public class PessoaJuridica : PessoaBase
    {
        public int NumeroFuncionarios { get; set; }
        
        public PessoaJuridica(){}

        public PessoaJuridica(string nome, double ganhoAnual, int numeroFuncionarios)
            :base(nome, ganhoAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        
        public override double TaxasPagas()
        {
            double valorTotal = 0.0;

            if (NumeroFuncionarios > 10)
                valorTotal = GanhoAnual * 0.14;
            else
                valorTotal = GanhoAnual * 0.16;

            return valorTotal;
        }
    }
}