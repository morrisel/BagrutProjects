using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num;
        bool equal;
        Console.WriteLine("Enter two-digit number");
        num = int.Parse(Console.ReadLine());

        equal = (num / 10 == num % 10);
        if (equal)
            Console.WriteLine(equal);
        else
            Console.WriteLine(equal);

        Console.ReadKey();
    }
}