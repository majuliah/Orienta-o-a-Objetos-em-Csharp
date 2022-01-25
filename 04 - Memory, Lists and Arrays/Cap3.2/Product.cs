namespace Cap3._2
{
    public class Product
    {
        public string ProductName { get;  set; }
        public double ProductValue { get;  set; }

        public Product(string productName, double productValue)
        {
            ProductName = productName;
            ProductValue = productValue;
        }
    }
}