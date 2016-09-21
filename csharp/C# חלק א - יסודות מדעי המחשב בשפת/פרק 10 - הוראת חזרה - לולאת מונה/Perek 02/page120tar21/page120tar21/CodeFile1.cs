using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int moneGova = 0, i;
        double gova;
        for (i = 1; i <= 5; i++)
        {
            gova = double.Parse(Console.ReadLine());
            if (gova > 1.50)
                moneGova++;
        }
        Console.WriteLine(moneGova);
        Console.ReadKey();
    }
}