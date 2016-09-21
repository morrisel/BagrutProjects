using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("Enter two numbers\n");
        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        if ((num1 > num2) || (num1 == num2))
        {
            if (num1 > num2)
            {
                Console.WriteLine("\nFirst number is more from second number");
                Console.WriteLine("num2 = {0},  num1 = {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("\nThe numbers is even");
                Console.WriteLine("num1 = {0},  num2 = {1}", num1, num2);
            }
        }
        else
        {
            Console.WriteLine("\nSecond number is more from first number");
            Console.WriteLine("num1 = {0},  num2 = {1}", num1, num2);
        }

        Console.ReadKey();
    }
}