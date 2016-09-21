using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int range, hours;

        Console.Write("Enter number for worker 1, 2, 3 or 4: ");
        range = int.Parse(Console.ReadLine());

        Console.Write("Enter an hours of worker ");
        hours = int.Parse(Console.ReadLine());

        switch (range)
        {
            case 1: Console.WriteLine("Your salary is: {0}", 100 * hours);
                break;
            case 2: Console.WriteLine("Your salary is: {0}", 80 * hours);
                break;
            case 3: Console.WriteLine("Your salary is: {0}", 50 * hours);
                break;
            case 4: Console.WriteLine("Your salary is: {0}", 20 * hours);
                break;
        }

        Console.ReadKey();
    }
}