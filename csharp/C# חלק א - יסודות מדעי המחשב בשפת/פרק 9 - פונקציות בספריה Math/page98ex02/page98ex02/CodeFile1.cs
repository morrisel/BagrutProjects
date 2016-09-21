using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double n1, n2, n3, max1, max2;
        int sqrt1, sqrt2, sqrt3;

        Random randNum = new Random();

        n1 = randNum.Next(20, 41);
        n2 = randNum.Next(20, 41);
        n3 = randNum.Next(20, 41);

        Console.WriteLine("\nThe numbers are: {0,4} {1,4} {2,4}\n", n1, n2, n3);

        max1 = Math.Max(n1, n2);
        max2 = Math.Max(max1, n3);

        Console.WriteLine("The biggest number is: {0,8} \n", max2);

        sqrt1 = (int)Math.Round(System.Math.Sqrt(n1));
        sqrt2 = (int)Math.Round(System.Math.Sqrt(n2));
        sqrt3 = (int)Math.Round(System.Math.Sqrt(n3));

        if (sqrt1 == sqrt2 || sqrt2 == sqrt3 || sqrt3 == sqrt1)
        {
            Console.WriteLine("Al least 2 numbers have the same round sqrt\n");
        }
        else
        {
            Console.WriteLine("All numbers have different round sqrt\n");
        }

        Console.ReadKey();
    }
}