using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, first, second, third;



        for (int i = 1; i <= 50; i++)
        {
            Console.Write("Enter three digit number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            first = num / 100;
            second = (num / 10) % 10;
            third = num % 10;

            if (num >= 100 && num < 1000)
            {
                if ((first != second) && (first != third) && (second != third))
                    Console.Write("the number is {0}\n\n", num);
                else
                    continue;
            }
            else
                continue;
        }

        Console.ReadKey();
    }
}