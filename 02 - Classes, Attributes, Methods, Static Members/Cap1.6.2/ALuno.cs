using static System.Console;
namespace Cap1._6._2
{
    public class ALuno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalculaNota()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (CalculaNota() >= 60.0)
                return true;
            else
                return false;
        }
        
        public double Reprovado()
        {
            if (Aprovado())
                return 0.0;
            else
                return (60.0 - CalculaNota());
        }
        
    }
}