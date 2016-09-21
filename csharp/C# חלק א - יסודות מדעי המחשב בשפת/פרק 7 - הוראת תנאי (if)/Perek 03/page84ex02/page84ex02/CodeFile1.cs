using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        bool check;
        int num;

        Console.WriteLine("Enter number");
        num = int.Parse(Console.ReadLine());
        check = (num > 10);
        if (check)
            Console.Write("Num is greater then 10");
        else
            Console.Write("Num is less of equal 10");
        Console.ReadKey();
    }
}