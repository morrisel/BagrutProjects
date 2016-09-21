using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page70tar14
{
    class Program
    {
        static void Main(string[] args)
        {
            int pinSprinter1, pinSprinter2;
            int timeSprinter1, timeSprinter2;

            Console.WriteLine("Enter any time of two sprinters\n");

            // Sprinter 1
            Console.Write("Enter a four digit pin number for Sprinter 1 ");
            pinSprinter1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the time of sprinter 1: ");
            timeSprinter1 = int.Parse(Console.ReadLine());

            // Sprinter 2
            Console.Write("Enter a four digit pin number for Sprinter 2 ");
            pinSprinter2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the time of sprinter 2: ");
            timeSprinter2 = int.Parse(Console.ReadLine());

            
            if (timeSprinter1 < timeSprinter2)
            {
                
                Console.WriteLine("The number of Sprinter 1 is: {0}", pinSprinter1);
                Console.WriteLine("The Sprinter 1   W o n!");
            }

            if (timeSprinter1 > timeSprinter2)
            {
                Console.WriteLine("The number of Sprinter 2 is: {0}", pinSprinter2);
                Console.WriteLine("The Sprinter 2   W o n!");
            }
            else
            {
                Console.WriteLine("The numbers of Sprinter 1 and Sprinter 2 is: {0} and {1}", pinSprinter1, pinSprinter2);
                Console.WriteLine("Their time is same: {0}", timeSprinter1);
            }
            


            Console.ReadKey();
        }
    }
}
