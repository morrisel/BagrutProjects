using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int c;
        char tav;
        Console.Write("Enter an 'a' or 'b' character: ");
        tav = char.Parse(Console.ReadLine());

        switch (tav)
        {
            case 'a': Console.WriteLine("Good"); break;
            case 'b': Console.WriteLine("Nice"); c = tav; break;
            default: Console.WriteLine("Not good"); break;
        }

        Console.ReadLine();
    }
}