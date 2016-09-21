using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n, count = 0;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            count++;
            n = n / 10;

            if (n < 10)         // תיקון לקטע
                n = n % 10;
        }
        Console.WriteLine(count);

        Console.ReadKey();
    }
}