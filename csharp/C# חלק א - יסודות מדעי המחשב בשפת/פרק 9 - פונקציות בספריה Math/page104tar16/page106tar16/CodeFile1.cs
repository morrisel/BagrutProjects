using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double num, nDig, nFloat, temp;
        double num1, nDig1;

        Console.WriteLine("enter a number");
        num = double.Parse(Console.ReadLine());

        nDig = Math.Floor(num);
        nFloat = (num * 1000) % 1000;
        Console.WriteLine("digit    " + nDig);
        Console.WriteLine("float    " + nFloat);

        temp = nFloat / 100;
        temp = Math.Round(temp);

        nDig1 = nDig * 10;
        num1 = nDig1 + temp;
        num1 = num1 / 10;

        Console.WriteLine("The number {0} is rounded to {1}", num, num1);

        Console.ReadKey();
    }
}