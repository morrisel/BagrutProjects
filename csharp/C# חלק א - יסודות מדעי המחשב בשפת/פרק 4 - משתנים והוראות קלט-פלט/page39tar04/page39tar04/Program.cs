using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page39tar04
{
    class Program
    {
        static void Main(string[] args)
        {
            char chOne;
            char chTwo;
            char chThree;

            Console.WriteLine("Insert three characters");
            chOne = char.Parse(Console.ReadLine());
            chTwo = char.Parse(Console.ReadLine());
            chThree = char.Parse(Console.ReadLine());

            Console.WriteLine(chOne + " " + chTwo + " " + chThree);
            Console.WriteLine(chThree + " " + chTwo + " " + chOne);
            Console.ReadKey();
        }
    }
}
