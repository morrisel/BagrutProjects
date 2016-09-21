using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, hun, ten, unit, sum;

        Console.Write("Enter a three-dimension number: ");
        num = int.Parse(Console.ReadLine());

        hun = num / 100;
        ten = (num % 100) / 10;
        unit = num % 100 % 10;
        Console.WriteLine("{0}, {1}, {2}", hun, ten, unit);
        sum = hun + ten + unit;
        Console.WriteLine(sum);

        if ((num % sum) == 0)
        {
            Console.WriteLine("YES");
        }

        Console.ReadKey();
    }
}