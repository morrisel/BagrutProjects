using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int units, tens;

        for (int i = 1; i < 100; i++)
        {
            units = i % 10;
            tens = i / 10;
            if (units == 7 || tens == 7 || i % 7 == 0)
            {
                Console.WriteLine("Boom");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadKey();
    }
}