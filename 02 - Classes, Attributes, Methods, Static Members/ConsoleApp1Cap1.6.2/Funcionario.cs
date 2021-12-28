using System.Globalization;

namespace ConsoleApp1Cap1._6._2
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioComImopsto()
        {
            return Salario - Imposto;
        }
        
        public void AumentaSalario(double porcentagem)
        {
             Salario = Salario + (Salario * (porcentagem / 100.0));
        }

        public override string ToString()
        {
            return ($"Funcionário: {Nome} tem o salário de " +
                    $"{SalarioComImopsto().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}