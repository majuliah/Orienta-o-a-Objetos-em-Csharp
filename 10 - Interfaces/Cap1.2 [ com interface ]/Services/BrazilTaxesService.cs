namespace services
{
    public class BrazilTaxesService : ITaxService
    //agora temos a classe de calcular taxas que é um SUBTIPO da interface ITaxService
    {
        public double Tax(double amount)
        //dessa forma agora implementamos o método da interface
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
        //a classe BrazilTexService está implementando o contrato estabelecido pela interface
    }
}