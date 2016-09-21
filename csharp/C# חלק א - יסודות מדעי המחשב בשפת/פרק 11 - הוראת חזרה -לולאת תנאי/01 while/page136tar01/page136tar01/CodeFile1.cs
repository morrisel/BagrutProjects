using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int mone = 0;

        while (mone <= 5)
        {
            Console.WriteLine("hello");
            mone = mone + 1;
        }
        Console.WriteLine("\n{0}", mone);
        Console.ReadKey();
    }
}