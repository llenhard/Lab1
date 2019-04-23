using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            double perimeter;
            bool continuing = true;

            while (continuing)
            {
                Console.WriteLine("Enter the length of the room: ");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the width of the room: ");
                width = double.Parse(Console.ReadLine());

                area = length * width;
                perimeter = (2 * length) + (2 * width);

                Console.WriteLine("Area: {0}\n" +
                    "Perimeter: {1}\n" +
                    "Do you want to calculate another room? (Y/N)", area, perimeter);

                if (Console.ReadLine() == "N")
                {
                    continuing = false;
                }
            }
            
        }
    }
}
