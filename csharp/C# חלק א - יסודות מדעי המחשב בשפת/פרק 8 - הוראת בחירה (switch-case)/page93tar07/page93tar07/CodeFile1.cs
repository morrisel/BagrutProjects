using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        char color;

        Console.WriteLine("Enter a color");
        color = char.Parse(Console.ReadLine());

        switch (color)
        {
            case 'c':
                Console.WriteLine("Enter an any color");
                color = char.Parse(Console.ReadLine());
                switch (color)
                {
                    case 'g': Console.WriteLine("Green"); break;
                    case 'b': Console.WriteLine("Blue"); break;
                    case 'v': Console.WriteLine("Violet"); break;
                    case 'y': Console.WriteLine("Grey"); break;
                    case 'k': Console.WriteLine("Black"); break;
                }
                break;
        }
        Console.ReadKey();
    }
}