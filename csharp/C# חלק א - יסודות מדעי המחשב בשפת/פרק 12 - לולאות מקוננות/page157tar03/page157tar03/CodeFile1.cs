using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int a1, a2, an;

        for (int i = 1; i <= 8; i++)
        {
            Console.Write("\nEnter a first number of pair ");
            a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number of pair ");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe pair putted is: ({0},{1})\n", a1, a2);
            if (a2 > a1)
            {
                an = a1;
                while (an <= a2)
                {
                    Console.Write("{0} ", an);
                    an = an + 1;
                }
            }

            if (a1 == a2)
                continue;

            if (a1 > a2)
            {
                an = a2;
                while (an <= a1)
                {
                    Console.Write("{0} ", an);
                    an++;
                }
            }
            Console.WriteLine("\n----------------------------------------------\n");
        }
        Console.ReadKey();
    }
}