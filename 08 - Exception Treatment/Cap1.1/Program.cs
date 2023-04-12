using System;
using System.IO;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numberOne = int.Parse(ReadLine());
                int numberTwo = int.Parse(ReadLine());

                int division = numberOne / numberTwo;
                WriteLine(division);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Division by 0 is not allowed!");
            }
            catch(FormatException e)
            {
                WriteLine($"Is not possible divide letters " + e.Message);
            }
            
            //using finaly:
            FileStream file = null;
            try
            {
                file = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader read = new StreamReader(file);
                string line = read.ReadLine();
                WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                WriteLine(e.Message);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }
    }
}