using System;

class CodeFile1
{
    static int Sod1(int n)
    {
        return n / 10;
        if (n > 100)
            return n / 100;
        //return n / 10;
    }



    static void Main(string[] args)
    {
        int num;
        double test;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        test = Sod1(num);
        Console.WriteLine("\n\n{0}", test);

        Console.ReadKey();
    }
}