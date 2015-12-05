using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect42Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to valid or invalid!");
            Console.WriteLine("Please enter a number between 1 andd 10");
            string numberAsAString = Console.ReadLine();
            int number = Convert.ToInt32(numberAsAString);

            if ((number >= 1) && (number <= 10))
            {
                Console.WriteLine("The number you eneterd is valid");
            }
            else
            {
                Console.WriteLine("The number you entered is invalid");
            }
            Console.ReadKey();
        }
    }
}
