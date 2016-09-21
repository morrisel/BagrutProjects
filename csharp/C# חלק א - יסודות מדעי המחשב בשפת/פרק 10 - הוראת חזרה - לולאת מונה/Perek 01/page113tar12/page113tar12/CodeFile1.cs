using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, tens, units;

        for (int i = 0; i < 100; )
        {
            Console.Write("\nEnter two-digit numbers: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            tens = num / 10;
            units = num % 10;

            if (num / 10 != units)
            {
                Console.WriteLine(" the two-digit number is:{0,12}", num);
                Console.WriteLine(" the sum of two-digit number is:{0,5}", tens + units);
            }
            else
                break;

            i = num;
            Console.WriteLine("\n\n");
        }

        Console.ReadKey();
    }
}