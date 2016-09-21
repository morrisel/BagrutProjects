using System;

// Prime number
class CodeFile1
{
    static void Main(string[] args)
    {
        int distance = 0;
        char first, second;

        for (int i = 1; i <= 20; i++)
        {
            first = char.Parse(Console.ReadLine());
            second = char.Parse(Console.ReadLine());

            distance = Math.Abs(second - first);
            
            Console.WriteLine(26 - (++distance));
        }

        Console.ReadKey();
    }
}