using System;

class CodeFile1
{
    static int What(int num1, int num2, int temp)
    {
        while (num1 % num2 != 0)
            num1 = num1 + temp;
        return num1;
    }



    public static void Main(string[] args)
    {
        int n1, n2, r;

        Console.WriteLine("Enter two numbers");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
            r = What(n1, n2, n1);
        else
            r = What(n2, n1, n2);

        Console.WriteLine(r);

        Console.ReadKey();
    }
}