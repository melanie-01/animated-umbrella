using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Braedon Write


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
