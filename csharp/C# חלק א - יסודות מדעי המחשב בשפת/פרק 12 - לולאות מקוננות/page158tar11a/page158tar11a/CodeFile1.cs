using System;

class CodeFile1
{
    static void Main(string[] args)
    {

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 2; j <= i+1; j++)
            {
                Console.Write("$");
            }
            Console.WriteLine("");
        }


        Console.ReadKey();
    }
}