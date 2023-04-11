using System;

namespace Cap1._5.Entities
{
    public class Crocheteira : Funcionario
    {
        public string TipoDeTrabalho { get; set; }
        public double RendaMensal { get; set; }
        
        public Crocheteira(){}

        public Crocheteira(string name, string profession, string tipoDeTrabalho, double rendaMensal)
            : base(name, profession)
        {
            TipoDeTrabalho = tipoDeTrabalho;
            RendaMensal = rendaMensal;
        }
    }
}