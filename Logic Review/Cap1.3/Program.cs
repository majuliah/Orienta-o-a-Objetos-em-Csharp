using static System.Console;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condicional Composta: 
            
            int x = 10;

            if (x < 5)
            {
                WriteLine("Boa Noite Chefiah");
            }else if (x > 10)
            {
                WriteLine("Bom diah! Chefiah!");    
            }
            else
            {
                WriteLine("Báh Táhrde");
            }
            
            
            
            // Atribuições de variáveis.
                //Para ser usada, uma variável precisa ser iniciada
                //Uma variável de escopo não pode ser usada fora do escopo em que foi declarada:

                double preco = 10.0;
                if (preco > 100.0)
                {
                    double desconto = preco * 1.0;
                }
                WriteLine(desconto);
                //dá problema porque ela somente pode ser vista dentro do espcopo em que foi criada
                //o mesmo ocorre da seguinte forma:

                double valor = 10.0;
                double desc;

                if (valor > 12.0)
                {
                    desc = valor * 1.0;
                }
                WriteLine(desc);
                //Dá erro porque a variável pode não vir a ser utilizada, o que leva ao problema de cima
                //uma variável não está sendo utilizada. Uma forma de arrumar
                //é setar o valor inicial de desc para 0.0;
                
        }
    }
}