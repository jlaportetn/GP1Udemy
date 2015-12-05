using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect42Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height of your image");
            var heightAsText = Console.ReadLine();
            var height = Convert.ToInt32(heightAsText);

            Console.WriteLine("Please enter the width of your image");
            var widthAsText = Console.ReadLine();
            var width = Convert.ToInt32(widthAsText);

            if (height > width)
            {
                Console.WriteLine("Your image is portrait");
            }
            else
            {
                Console.WriteLine("Your image is landscape");
            }
        }
    }
}
