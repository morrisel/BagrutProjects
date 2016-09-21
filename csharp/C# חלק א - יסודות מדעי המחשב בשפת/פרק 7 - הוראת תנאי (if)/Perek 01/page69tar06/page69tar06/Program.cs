using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page69tar06
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstNameLetter = 'M';
            char lastNameLetter = 'E';

            Console.Write("Enter first letter of your first name \"M\": ");
            firstNameLetter = char.Parse(Console.ReadLine());
            Console.Write("Enter first letter of you last name \"E\": ");
            lastNameLetter = char.Parse(Console.ReadLine());
            if (firstNameLetter > lastNameLetter)
            {
                Console.WriteLine("Morris Elkanaev");
            }
            else
                Console.WriteLine("Elkanaev Morris");

            Console.ReadKey();
        }
    }
}
