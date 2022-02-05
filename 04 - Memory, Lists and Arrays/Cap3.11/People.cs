namespace Cap3._11
{
    abstract public class People
    {
        public string Name;
        public string MiddleName;
        public int BirthDate;

        public People()
        {
            
        }

        public People(string name, string middleName, int birthDate)
        {
            this.Name = name;
            this.MiddleName = middleName;
            this.BirthDate = birthDate;
        }


        public int Age(int birthYear)
        {
            BirthDate = 2022 - birthYear;
            return BirthDate;
        }
        
    }
}