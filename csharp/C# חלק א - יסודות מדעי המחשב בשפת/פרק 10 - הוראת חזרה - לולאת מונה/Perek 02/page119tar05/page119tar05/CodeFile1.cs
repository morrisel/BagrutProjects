using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, dividers = 0, i;
        Console.WriteLine("Enter an integer number");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("num = {0}", num);
        Console.WriteLine("The dividers are:");
        for (i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine(i);
                dividers++;
            }
        }
        Console.WriteLine("Number of dividers: {0}", dividers);

        Console.ReadKey();
    }
}