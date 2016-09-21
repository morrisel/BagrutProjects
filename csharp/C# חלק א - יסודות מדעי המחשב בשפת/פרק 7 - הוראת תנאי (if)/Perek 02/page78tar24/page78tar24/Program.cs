using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar24
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int chInt;

            Console.WriteLine("Please enter an any character from your keyboard");

            ch = char.Parse(Console.ReadLine());
            
            chInt = (int)ch;

            if ((chInt >= 97) && (chInt <= 122))
                Console.WriteLine("You entered character one of them [a - z]");
            else
                Console.WriteLine("Your entered charcter not one of them [a - z]");

            Console.ReadKey();
        }
    }
}
