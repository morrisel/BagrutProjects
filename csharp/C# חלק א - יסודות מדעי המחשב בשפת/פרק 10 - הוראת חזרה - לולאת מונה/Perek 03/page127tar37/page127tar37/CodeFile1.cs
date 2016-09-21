using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int accumulation = 0, num;

        Console.WriteLine();

        for (int i = 1; i <= 8; i++)
        {
            Console.Write("Enter an interger number: ");
            num = int.Parse(Console.ReadLine());

            if (num > 10 && num < 100)
            {
                if (num % 2 == 0)
                {
                    accumulation = accumulation + num;
                    Console.WriteLine("num{0} = {1}\n", i, num);
                }
                else
                    Console.WriteLine("num{0} = {1}\n", i, num);
            }
            else
                Console.WriteLine("num{0} = {1}\n", i, num);
        }

        Console.WriteLine("\n\nThe sum of two digit even number is: {0}", accumulation);

        Console.ReadKey();
    }
}