using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        bool divider = true;
        int num;

        Console.WriteLine("Enter number");
        num = int.Parse(Console.ReadLine());

        if (divider)
        {
            num = num * 3;
            Console.WriteLine(num);
        }

        Console.ReadKey();

    }
}