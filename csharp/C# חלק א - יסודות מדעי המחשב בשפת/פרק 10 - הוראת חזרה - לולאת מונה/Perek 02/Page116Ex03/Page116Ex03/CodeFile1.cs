using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count = 0, tens, units;
        for (int i = 1; i < 100; i++)
        {
            units = i % 10;
            tens = i / 10;
            if ((i % 7 == 0) || (tens == 7) || (units == 7))
                count++;
        }
        
        Console.WriteLine("There are " + count + " boom numbers");
        Console.ReadKey();
    }
}