using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect48Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // I needed  a lot of "help" from jpaxsontn's code to figure this one out.
            // I had trouble with this excersise

            Console.WriteLine("Please enter a series of numbers separated by a comma.");
            var userEntry = Console.ReadLine();
            var stringOfNumbers = userEntry.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var largestNumber = FindLargestNumber(stringOfNumbers);
            Console.WriteLine("The largest number is " + largestNumber);
            Console.ReadKey();
        }

        public static int FindLargestNumber(string[] stringOfNumbers)
        {
            int largestNumber = 0;
            for (var iCounter = 0; iCounter <= stringOfNumbers.Count() - 1; iCounter++)
            {
                int validNumber = 0;
                if (Int32.TryParse(stringOfNumbers[iCounter], out validNumber))
                {
                    if (validNumber > largestNumber)
                    {
                        largestNumber = validNumber;
                    }
                }
            }
            return largestNumber;
        }
    }
}
