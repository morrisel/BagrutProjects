using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int fib = 0, f1 = 0, f2 = 1, count = 2, n, sum = 0;

        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());

        //Console.Write("\n {0} ", f1);
        //Console.Write("\n {0} \n", f2);

        Console.Write(" {0} ", f1);
        Console.Write(" {0} ", f2);

        while (count < n)
        {
            fib = f1 + f2;
            f1 = f2;
            f2 = fib;

            sum = sum + fib;
            count++;

            Console.Write(" {0} ", fib);
            //Console.WriteLine("\n            sum = {0}", sum + 1);
        }
        Console.WriteLine();
        Console.WriteLine("\n\nsum = {0}", sum + 1);

        Console.ReadKey();
    }
}