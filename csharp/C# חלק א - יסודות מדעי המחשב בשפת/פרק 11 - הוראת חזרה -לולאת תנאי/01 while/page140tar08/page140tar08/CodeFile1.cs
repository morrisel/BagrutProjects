using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count = 0, num;
        Console.WriteLine("The program counted a positive number.");
        Console.WriteLine("For stop the program enter an any integer number.\n");
        Console.Write("Enter a positive number: ");
        num = int.Parse(Console.ReadLine());

        while (num >= 0)
        {
            count++;
            Console.Write("Enter a positive number: ");
            num = int.Parse(Console.ReadLine());
        }
        Console.Write("The positive numbers are putted: {0}", count);

        Console.ReadKey();
    }
}