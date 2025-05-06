using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Braedon Write
            Console.WriteLine("Hi my name is Braedon");
            Console.Write("Please enter the starting letter: ");
            string temp = Console.ReadLine();
            Console.WriteLine("");
            char start = Convert.ToChar(temp);
            Console.Write("Please enter the stopping letter: ");
            temp = Console.ReadLine();
            Console.WriteLine("");
            char stop = Convert.ToChar(temp);
            for (int row = start; row <= stop; row++)
            {
                for (char col = start; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            //Melanie
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
            Console.ReadLine();
            //Albert
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
