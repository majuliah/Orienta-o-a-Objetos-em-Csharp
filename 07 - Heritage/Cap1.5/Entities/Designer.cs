using System;

namespace Cap1._5.Entities
{
    public class Designer : Funcionario
    {
        public string TipoDeTrabalho { get; set; }
        public double RendaMensal { get; set; }
        public string PacoteDeSoftwares { get; set; }
        
        public Designer(){}

        public Designer(string name, string profession, string tipoDeTrabalho, double rendaMensal, string pacoteDeSoftwares)
            : base(name, profession)
        {
            TipoDeTrabalho = tipoDeTrabalho;
            RendaMensal = rendaMensal;
            PacoteDeSoftwares = pacoteDeSoftwares;
        }
        
    }
}