using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count, mone, num;
        for (count = 0, mone = 1; (count <= 3 && mone <= 50); mone++)
        {
            num = int.Parse(Console.ReadLine());
            if (num / 10 - num % 10 == 1)
                count++;
            mone++;
        }
        Console.WriteLine("\nThere are " + count + " numbers after " + mone + " times");

        Console.ReadKey();
    }
}