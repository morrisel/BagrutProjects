using System;

class CodeFile1
{
    static long What(double num)
    {
        return (long)(num + 0.5);
    }

    public static void Main(string[] args)
    {

        Console.WriteLine(What(7.7));
        Console.WriteLine(What(8.9));
        Console.WriteLine(What(9.2));
        Console.WriteLine(What(9.4));
        Console.ReadKey();
    }
}