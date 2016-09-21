using System;

// Prime number
class CodeFile1
{
    static void Main(string[] args)
    {
        int num, i, countNum = 0;

        Console.Write("Enter an integer number: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("\n\n");

        i = num;

        for (; 1 < num; num--)
        {
            if (i % num == 0)
                countNum++;
        }

        if (countNum <= 2)
            Console.WriteLine("{0} is a Prime number", i);
        else
            Console.WriteLine("{0} is not a Prime number", i);

        Console.ReadKey();
    }
}