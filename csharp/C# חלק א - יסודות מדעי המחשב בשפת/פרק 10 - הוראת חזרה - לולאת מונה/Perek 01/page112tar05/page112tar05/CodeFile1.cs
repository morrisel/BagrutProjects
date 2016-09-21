using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("My name is Morris");
            }
            else
            {
                if (i == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("My address is Halutzat ha pardesanut 17/6, Petah Tikva");
                }
            }
        }
        Console.ReadKey();
    }
}