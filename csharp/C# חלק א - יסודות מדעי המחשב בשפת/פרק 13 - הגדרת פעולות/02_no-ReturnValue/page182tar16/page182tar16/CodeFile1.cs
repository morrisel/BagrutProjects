using System;

class CodeFile1
{
    static void Demo(int x)
    {
        Console.WriteLine("x = {0}", x);
        Console.WriteLine("*******");
    }


    public static void Main(string[] args)
    {
        int num = 4;

        for (int i = 1; i <= num; i++)
        {
            Demo(i);
            Console.WriteLine(i + 1);
        }

        Console.ReadKey();
    }
}