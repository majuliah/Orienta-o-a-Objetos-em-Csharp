using static System.Console;
using System.Collections.Generic;

namespace Cap3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Lists");
            
            List<string> myFirstList = new List<string>();
            List<string> otherList;
            List<string> namesLists = new List<string> { "Maria", "Alex", "Maramusa" };
            
            WriteLine("Practice demonstration of Lists: ");

            List<string> manipulatingLists = new List<string>();
            manipulatingLists.Add("Marajó");
            //you can add list of objects, like this:
            // manipulatingLists.Add(new Product("TV", 900, 2));
            
            manipulatingLists.Add("Antonietta");
            manipulatingLists.Add("Julihan");
            manipulatingLists.Add("Abraham");
            manipulatingLists.Add("Abbaston");
            manipulatingLists.Add("Loreniel");
            
            //the items contained at list will be in order 
            //of their added

            foreach (var name in manipulatingLists)
                WriteLine(name);
            
            //you can also add items at the position you want
            //if the position is already allocated, the list 
            //will allocate the item you want at the position,
            //and the rest of items will be reallocated 
            
            WriteLine($"-----------------------------");
            
            manipulatingLists.Insert(2, "Borabharn");

            foreach (var name in manipulatingLists)
                WriteLine(name);
            
            WriteLine($"Items contained at list: " + manipulatingLists.Count);
            
            WriteLine($"-----------------------------");

            string findingLambda = manipulatingLists.Find(incidence => incidence[0] == 'A');
            WriteLine($"First name at list that begins with the letter A is: {findingLambda}");
            
            string findingLast = manipulatingLists.FindLast(incidence => incidence[0] == 'A');
            WriteLine($"Last name at list that begins with the letter A is: {findingLast}");
            
            WriteLine($"\n \n \n");

            int findIndex = manipulatingLists.FindIndex(incidence => incidence[0] == 'B');
            WriteLine($"The POSITION of the first name that begin with the letter B is: {findIndex}");
            
            WriteLine($"\n ");
            
            int findLastIndex = manipulatingLists.FindLastIndex(incidence => incidence[0] == 'B');
            WriteLine($"The POSITION of the LAST name that begin with the letter B is: {findLastIndex}");
            
            WriteLine($"\n \n \n");
            
            WriteLine($"-------------------------------------");
            //Also, you can create another list from the ones you got, that will contains what you want
            
            List<string> resultOfNamesWithA =
                new List<string>(manipulatingLists.FindAll(incidence => incidence[0] == 'A'));
            //every name that begins with letter A

            foreach (var name in resultOfNamesWithA)
                WriteLine(name);

            WriteLine($"-------------------------------------");
            resultOfNamesWithA = manipulatingLists.FindAll(incidence => incidence.Length == 6);
            //every name that the size is equal to 6
            
            foreach (var name in resultOfNamesWithA)
                WriteLine(name);
            
            WriteLine($"------------------------------------- \n \n");

            manipulatingLists.Remove("Abraham");
            foreach (var name in manipulatingLists)
                WriteLine(name);
            //delete the parameter passed

            WriteLine($"------------------------------------- \n \n");
            
            manipulatingLists.RemoveAll(incidence => incidence[0] == 'A');
            //delete every incidence passed at parameter 
            //every name that begins with letter A:
            
            foreach (var name in manipulatingLists)
                WriteLine(name);
            
            WriteLine($"------------------------------------- \n \n");
            
            manipulatingLists.RemoveAt(3);
            //will remove at the position you passed
            
            foreach (var name in manipulatingLists)
                WriteLine(name);
            
            WriteLine($"------------------------------------- \n \n");
            
            manipulatingLists.RemoveRange(0, 2);
            //will remove at the position you passed in a range
            //from the position 0, 2 units 
            
            foreach (var name in manipulatingLists)
                WriteLine(name);
            
            WriteLine($"------------------------------------- \n \n");
            
            
            






        }
    }
}