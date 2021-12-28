namespace Cap1._6._2
{
    public class ALuno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalculaMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}