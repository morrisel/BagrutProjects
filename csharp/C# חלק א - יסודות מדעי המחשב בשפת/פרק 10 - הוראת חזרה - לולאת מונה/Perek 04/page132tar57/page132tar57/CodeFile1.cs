using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int nb, sn = 0;


         
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Enter a number of notebooks who student {0} buy\t", i);
            nb = int.Parse(Console.ReadLine());
            sn = sn + nb;
        }

        Console.WriteLine("\nThe students are buying {0} notebooks", sn);
        Console.ReadKey();
    }
}