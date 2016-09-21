using System;

class CodeFile1
{
    static void P2(int num)
    {
        double top = Math.Sqrt(num);
        for(int i=1;i<=top;i++)
            if (num % i == 0)
            {
                Console.WriteLine("{0,14}\t{1}\n   ........................", num / i, i);
                if (i != num / i)
                    Console.WriteLine("{0,14}\t{1}\n   ........................", i, num / i);
            }
    }

    public static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Enter a number");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        P2(n);

        Console.ReadKey();
    }
}