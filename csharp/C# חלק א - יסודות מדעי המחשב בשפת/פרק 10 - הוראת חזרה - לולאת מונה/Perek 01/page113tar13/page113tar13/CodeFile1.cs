using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("Enter two nubers so that (num1 < num2)");

        Console.Write("Enter a num1 ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a num2 ");
        num2 = int.Parse(Console.ReadLine());

        for (int i = num1; i <= num2; i++)
        {
            Console.WriteLine(num1);
            num1++;
        }



        Console.ReadKey();
    }
}