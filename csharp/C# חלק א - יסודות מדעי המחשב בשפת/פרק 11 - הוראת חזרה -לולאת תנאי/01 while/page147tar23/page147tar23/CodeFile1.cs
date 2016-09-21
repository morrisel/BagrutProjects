using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int x, y, sum = 0, max = 0;
        bool flg = false;

        while (!flg)
        {
            Console.Write("Enter a first number of pair: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number of pair: ");
            y = int.Parse(Console.ReadLine());

            if (x % 2 != 0 && y % 2 != 0)
                Console.WriteLine("The pair was putted is: ({0},{1})\n", x, y);
            else
            {
                if (x % 2 != 0 || y % 2 != 0)
                    flg = true;
                else
                    Console.WriteLine("The pair was putted is: ({0},{1})\n", x, y);
            }

            sum = x + y;

            if (sum > max)
                max = sum;
        }
        Console.WriteLine("\nThe big sum of difference of pair's number is: {0}", max);

        Console.ReadKey();
    }
}