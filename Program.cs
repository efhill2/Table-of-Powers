using System;
using System.Runtime.CompilerServices;

namespace Table_of_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Learn your squares and cubes!");

            bool keepGoing = true;

            string numberHeader = "Number";
            string squaredHeader = "Squared";
            string cubedHeader = "Cubed";

            while (keepGoing)
            {
               
                Console.WriteLine("Please enter positive number");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber <= 0)
                {
                    Console.WriteLine("NO NEGATIVE NUMBERS");

                }
                else if (userNumber > 1290)
                {
                    Console.WriteLine("Number to large");
                }
                else
                {
                   
                    Console.WriteLine($"{numberHeader,-10}{squaredHeader,-10}{cubedHeader,-10}");
                    Console.WriteLine("======" + "\t" + "======" + "\t" + "======");

                    for (int i = 1; i <= userNumber; i++)
                    {
                        int squared = i * i;
                        int cubed = i * i * i;

                        Console.WriteLine($"{i,8}{squared,8}{cubed,8}");
                    }
                                      
                }

                Console.WriteLine("Continue? (y/n)");
                string cont = Console.ReadLine().ToLower();

                if (cont == "n")
                {
                    keepGoing = false;
                }
                
            }
        }
    }
}
