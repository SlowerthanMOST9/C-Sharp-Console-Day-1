using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!");
            Console.WriteLine("Hello" + "There");
            Console.Write("What is your name? ");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.Write("How many hours of sleep did you get last night ");
            int hourOfSleep = int.Parse(Console.ReadLine());

            if (hourOfSleep >= 8)
            {
                Console.WriteLine("Good job. Thats a lot of sleep.");
            }
            else if (hourOfSleep >= 6)
            {
                Console.WriteLine("Not bad, but you need more sleep.");
            }
            else
            {
                Console.WriteLine("I don't know what you wrote.");
            }



            Console.ReadKey();
        }
    }
}
