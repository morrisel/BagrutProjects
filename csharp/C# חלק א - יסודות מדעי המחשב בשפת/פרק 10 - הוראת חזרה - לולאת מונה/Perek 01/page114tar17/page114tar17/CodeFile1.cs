using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        Console.WriteLine("New Pairs\n");

        int a, b, temp;

        for (int i = 1; i <= 35; i++)
        {
            Console.WriteLine("\nEnter two integer numbers a and b");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers that putted [a,b] is: {0} and {1}", a, b);


            if (a != b)
            {
                if (a > b)
                {
                    temp = a;
                    a = b;
                    b = temp;

                    a++;
                    b--;
                    Console.WriteLine("The a and b numbers would be changed [{0}, {1}]", b, a);
                }
                else
                {
                    a++;
                    b--;
                    Console.WriteLine("The a and b numbers would be changed [{0}, {1}]", a, b);
                }
            }
            else
                continue;
        }
        Console.ReadKey();
    }
}