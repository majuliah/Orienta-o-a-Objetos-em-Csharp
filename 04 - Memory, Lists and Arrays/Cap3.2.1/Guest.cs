namespace Cap3._2._1
{
    public class Guest
    {
        public string Name { get;  set; }
        public string Email { get;  set; }
        public int NumberOfRoom { get;  set; }


        public Guest( string name, string email, int numberOfRoom)
        {
            Name = name;
            Email = email;
            NumberOfRoom = numberOfRoom;
        }

        public override string ToString()
        {
            return (@$"
                      Name:        {Name}
                      Email:       {Email}
                      Room Number: {NumberOfRoom}
            ");
        }
    }
}