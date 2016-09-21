using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n1, n2;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter two integer numbers");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1 % n2 == 0)
            {
                Console.WriteLine("{0} divided by {1}", n1, n2);
            }
            else
            {
                if (n2 % n1 == 0)
                {
                    Console.WriteLine("{0} divided by {1}", n2, n1);
                }
                else
                {
                    Console.WriteLine("not divided");
                }
            }
        }

        Console.ReadKey();
    }
}