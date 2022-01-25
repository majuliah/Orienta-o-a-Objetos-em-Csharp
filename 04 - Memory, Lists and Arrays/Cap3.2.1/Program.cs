using static System.Console;

namespace Cap3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Working with Arrays!");
            WriteLine();
            WriteLine();
            WriteLine("------------------------------------------------------------");
            WriteLine("               Welcome to Majubs Hotel!                     ");
            WriteLine("We have 10 rooms free today. How many people will be here?  ");
            
            int numberOfGuests = int.Parse(ReadLine());
            WriteLine("     Thats nice! Lets alocate them up!                      ");

            Guest[] willStayTonight = new Guest[10];

            for (int i = 0; i < numberOfGuests; i++)
            {
                WriteLine($"Enter with a Name, Email and a Number of the room you want to spend the night ");
                string name = ReadLine();
                string email = ReadLine();
                int numberOfRoom = int.Parse(ReadLine());
                willStayTonight[numberOfRoom] = new Guest(name, email, numberOfRoom);
            }

            for (int i = 0; i < 10; i++)
            {
                if (willStayTonight[i] != null)
                    WriteLine($"{willStayTonight[i]}");
            }
            
        }
    }
}