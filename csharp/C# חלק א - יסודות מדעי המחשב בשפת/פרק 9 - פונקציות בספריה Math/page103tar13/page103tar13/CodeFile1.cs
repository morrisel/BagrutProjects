using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double sum, rem;

        double shekel, agorot;

        Console.WriteLine("Enter a sum of money");

        sum = double.Parse(Console.ReadLine());

        shekel = Math.Floor(sum);
        Console.Write("You putted  {0} shekels ", shekel);

        rem = sum % shekel;
        agorot = rem * 100;

        agorot = Math.Round(agorot);

        if (agorot < 10)
        {
            Console.Write("and  {0} agorots", agorot);
            rem = rem * 10;
            Console.Write("and  {0} agorots", rem);
        }
        else
        {
            if (agorot % 10 == 0)
            {
                Console.Write("and  {0} agorots", agorot);
                agorot = agorot / 10;
                Console.Write("and  {0} agorots", agorot);
            }
            else
            {
                Console.Write("and  {0} agorots", agorot);
            }
        }

        Console.ReadKey();
    }
}