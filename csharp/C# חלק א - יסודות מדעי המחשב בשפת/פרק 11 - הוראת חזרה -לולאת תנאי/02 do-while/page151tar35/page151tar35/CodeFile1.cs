using System;

// The program find a similar pairs
class CodeFile1
{
    static void Main(string[] args)
    {
        int n1, n2, num, count = 0;
        int rem_n1, div_n1, rem_n2, div_n2;

        Console.WriteLine("\nFor stop the programm press -1");
        Console.WriteLine(".....................................");
        Console.Write("\nEnter two digit number: ");
        num = int.Parse(Console.ReadLine());
        n1 = num;
        rem_n1 = n1 % 10;
        div_n1 = n1 / 10;

        do
        {
            Console.Write("\nEnter two digit number: ");
            num = int.Parse(Console.ReadLine());
            n2 = num;
            rem_n2 = n2 % 10;
            div_n2 = n2 / 10;

            if (num == -1)
                break;

            if (n1 == n2 || (rem_n1 == div_n2 && rem_n2 == div_n1))
            {
                Console.WriteLine("\nThese {0} , {1} a similar pair", n1, n2);
                count++;
            }
            else
                Console.WriteLine("\nThese {0} , {1} is not a similar pair", n1, n2);

            Console.WriteLine(".....................................");
            Console.Write("\nEnter two digit number: ");
            num = int.Parse(Console.ReadLine());
            n1 = num;
            rem_n1 = n1 % 10;
            div_n1 = n1 / 10;
        }
        while (num != -1);

        Console.ReadKey();
    }
}