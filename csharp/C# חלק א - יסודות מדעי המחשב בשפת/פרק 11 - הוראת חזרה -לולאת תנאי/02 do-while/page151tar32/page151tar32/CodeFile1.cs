using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        char ch;
        int count = 0;

        ch = char.Parse(Console.ReadLine());
        do
        {
            count++;
            ch = char.Parse(Console.ReadLine());
        }
        while (ch != 'M');
        Console.WriteLine(count);

        Console.ReadKey();
    }
}