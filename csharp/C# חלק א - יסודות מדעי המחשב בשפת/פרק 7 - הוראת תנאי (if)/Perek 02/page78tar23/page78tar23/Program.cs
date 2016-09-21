using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar23
{
    class Program
    {
        static void Main(string[] args)
        {
            int experience, age;

            Console.Write("Enter your experience years: ");
            experience = int.Parse(Console.ReadLine());
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            if ((experience >= 3) && ((age < 35) || (age > 45)))
                Console.WriteLine("You qualify on this position isn't match");

            if ((experience < 3) && ((age >= 35) || (age <= 45)))
                Console.WriteLine("You qualify on this position isn't match");

            if ((experience >= 3) && (age >= 35) && (age <= 45))
                Console.WriteLine("The position is open for you ");

            Console.ReadKey();
        }
    }
}
