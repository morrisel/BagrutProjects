using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int length, width;

        Console.Write("Insert lenght: ");
        length = int.Parse(Console.ReadLine());
        Console.Write("Insert width: ");
        width = int.Parse(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
                Console.Write("*");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}