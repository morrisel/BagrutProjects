using System;

class CodeFile1
{
    static void Main()
    {
        int num;
        bool even;

        Console.WriteLine("Enter any number");
        num = int.Parse(Console.ReadLine());

        even = num % 2 == 0;
        Console.WriteLine(even);

        Console.ReadKey();
    }
}