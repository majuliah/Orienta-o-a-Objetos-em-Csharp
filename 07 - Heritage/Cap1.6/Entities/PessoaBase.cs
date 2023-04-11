namespace Cap1._6.Entities
{
    public abstract class PessoaBase
    {
        public string Nome { get; set; }
        public double GanhoAnual { get; set; }
        
        public PessoaBase(){}

        protected PessoaBase(string nome, double ganhoAnual)
        {
            Nome = nome;
            GanhoAnual = ganhoAnual;
        }
        
        public abstract double TaxasPagas();
    }
}