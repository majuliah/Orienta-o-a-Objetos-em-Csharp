using System;

namespace Cap1._6.Entities
{
    public class PessoaFisica : PessoaBase
    {
        public double PlanoSaude { get; set; }
        
        public PessoaFisica(){}

        public PessoaFisica(string nome, double ganhoAnual, double planoSaude)
        :base(nome, ganhoAnual)
        {
            PlanoSaude = planoSaude;
        }

        public override double TaxasPagas()
        {
            double valorFinal = 0.0;

            if (GanhoAnual < 20000.00)
                valorFinal = (GanhoAnual * 0.15) - (PlanoSaude * 0.50);
            else if (GanhoAnual > 20000.00)
                valorFinal = (GanhoAnual * 0.25) - (PlanoSaude * 0.50);

            return valorFinal;
        }
    }
}