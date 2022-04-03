namespace Reviews2
{
    public class Emplyee
    {
        private string _name;  
        public double Salary { get; private set; }
        public int Age { get; set; }

        public string SetName
        {
            get { return _name; }
            set
            {
                if (value != null || value.Length > 3)
                {
                    _name = value;    
                }
                
            }
        }
    }
}