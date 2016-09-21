using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        bool check;
        int num1, num2;

        Console.WriteLine("Enter 2 numbers");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());

        check = num1 > num2;
        Console.WriteLine(check);

        check = num1 < num2;
        Console.WriteLine(check);

        check = num1 != num2;
        Console.WriteLine(check);

        check = (num1 == num2);
        Console.WriteLine(check);

        Console.ReadKey();

    }
}