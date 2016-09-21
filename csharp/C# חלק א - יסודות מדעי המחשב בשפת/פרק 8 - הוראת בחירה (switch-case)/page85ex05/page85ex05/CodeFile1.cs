using System;

class CodeFile
{
    static void Main(string[] args)
    {
        char tav, c;


        tav = char.Parse(Console.ReadLine());

        switch (tav)
        {
            case 'a': Console.WriteLine("Good");
                break;
            case 'b': Console.WriteLine("Nice");
                c = tav;
                break;
            default: Console.WriteLine("Not good");
                break;
        }



        int letterToNumber;
        letterToNumber = (char)'M';

        char test;
        test = (char)65;

        Console.WriteLine(++test);
        Console.WriteLine(letterToNumber);

        Console.ReadKey();
    }
}