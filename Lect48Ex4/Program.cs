using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect48Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Please enter a number between 1 and 10");
            for (var chances = 0; chances <= 3; chances++)
            {
                var userEntry = Console.ReadLine();
                var guess = Convert.ToInt32(userEntry);
                var answer = (random.Next(1, 10));

                if (guess == answer)
                {
                    Console.WriteLine("You Win!");
                    Console.ReadKey();
                }
                Console.WriteLine("You Lost, try again.");
            }
            Console.WriteLine("Out of chances, press any key to exit");
            Console.ReadKey();
        }
    }
}
