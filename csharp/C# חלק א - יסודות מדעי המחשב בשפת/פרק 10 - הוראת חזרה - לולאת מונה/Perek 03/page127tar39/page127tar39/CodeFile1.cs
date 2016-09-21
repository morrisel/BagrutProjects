using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int mult = 1, i, num;

        Console.Write("Enter a number, num = ");
        num = int.Parse(Console.ReadLine());

        for (i = 1; i <= num; i++)
        {
            mult = mult * i;
        }
        
        Console.WriteLine("Factorial = {0}", mult);

        Console.ReadKey();
    }
}