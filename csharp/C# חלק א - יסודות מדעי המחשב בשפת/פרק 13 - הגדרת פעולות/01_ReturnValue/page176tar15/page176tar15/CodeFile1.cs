using System;

class CodeFile1
{
    /*
    static int Equal1(int n1, int n2)
    {
        while (n1 != 0 && n2 != 0)
        {
            n1 = n1 / 10;
            n2 = n2 / 10;
        }

        if (n1 == 0 && n2 == 0)
            return 1;
        else
            return 0;
    }
    */

    static int CountDigit(int num)
    {
        int counter = 0;

        while (num > 0)
        {
            num = num / 10;
            counter++;
        }
        return counter;
    }

    static int Equal2(int n1, int n2)
    {
        n1 = CountDigit(n1);
        n2 = CountDigit(n2);

        if (n1 == 0 && n2 == 0)
            return 1;
        else
            return 0;
    }

    public static void Main(string[] args)
    {
        int num1, num2, n;

        Console.WriteLine("Enter a number");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());

        //n = Equal1(num1, num2);

        n = Equal2(num1, num2);
        Console.WriteLine("Equal2  - >   {0}", n);

        //n = CountDigit(num1);
        //Console.WriteLine(n);

        Console.ReadKey();
    }
}