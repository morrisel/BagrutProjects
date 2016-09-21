using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int ex, b, num = 1;

        Console.Write("Enter a base number: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter an exponent number: ");
        ex = int.Parse(Console.ReadLine());

        for (int i = 1; i <= ex; i++)
        {
            num = num * b;
            Console.Write("{0}  ", num);
        }
        Console.WriteLine("\n\n{0}", num);

        Console.ReadKey();
    }
}