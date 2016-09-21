using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int d1, d2, temp;

        Console.WriteLine("The Hot Days\n");

        Console.Write("Write a temperature of day1: ");
        d1 = int.Parse(Console.ReadLine());
        Console.Write("Write a temperature of day2: ");
        d2 = int.Parse(Console.ReadLine());

        for (int i = 2; i <= 30; i += 1)
        {
            if ((d1 > d2) && (d1 > 25))
            {
                temp = d1;
                d1 = d2;
                d2 = temp;
                Console.WriteLine(" {0} ", i);
            }
            Console.Write("Write a temperature of day: ");
            d1 = int.Parse(Console.ReadLine());
        }
        Console.ReadKey();
    }
}