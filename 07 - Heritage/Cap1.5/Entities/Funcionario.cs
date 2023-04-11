using System;

namespace Cap1._5.Entities
{
    public abstract class Funcionario
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        
        public Funcionario(){}

        public Funcionario(string name, string profession)
        {
            Name = name;
            Profession = profession;
        }
    }
}