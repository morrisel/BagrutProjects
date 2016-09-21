using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        bool flg = false;
        int num, rem, div, inv = 0;

        Console.Write("Enter two-digit or more digits integer number: ");
        num = int.Parse(Console.ReadLine());

        while (!flg)
        {
            if (num / 10 == 0)
                flg = true;

            div = num / 10;
            rem = num % 10;
            inv = inv * 10 + rem;
            num = div;
            
        }
        Console.WriteLine("\n{0}", inv);

        Console.ReadKey();
    }
}