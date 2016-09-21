using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        char color;

        Console.WriteLine("Enter the first character of colors' name");
        Console.WriteLine("<< For example r, g, b and so on >>");
        color = char.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (color)
        {
            case 'r': Console.WriteLine("Red"); break;
            case 'g': Console.WriteLine("Green or gray"); break;
            case 'b': Console.WriteLine("Blue of brown or black"); break;
            case 'w': Console.WriteLine("White"); break;
            case 'y': Console.WriteLine("Yello"); break;
            case 'o': Console.WriteLine("Orange"); break;
            case 'p': Console.WriteLine("Pink of purple"); break;
        }

        Console.ReadKey();
    }
}