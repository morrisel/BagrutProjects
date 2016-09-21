using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num1, num2;
        bool found;
        Console.WriteLine("Enter two numbers\n");

        Console.Write("num1 = ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("num2 = ");
        num2 = int.Parse(Console.ReadLine());

        found = (num1 == num2);

        if (found)
        {
            Console.WriteLine("num1 = num2");
        }
        else
        {
            Console.WriteLine("num1 != num2");
        }

        Console.ReadKey();
    }
}