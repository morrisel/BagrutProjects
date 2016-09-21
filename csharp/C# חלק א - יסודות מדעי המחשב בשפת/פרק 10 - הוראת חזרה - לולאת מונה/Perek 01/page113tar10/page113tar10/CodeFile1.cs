using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 100; i += 5)
            Console.Write("{0} ", i);

        Console.ReadKey();
    }
}