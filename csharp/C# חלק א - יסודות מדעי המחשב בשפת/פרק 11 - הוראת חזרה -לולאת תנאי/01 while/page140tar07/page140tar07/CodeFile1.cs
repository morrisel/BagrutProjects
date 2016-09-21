using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, mult = 1, div;

        Console.WriteLine("\nThe product of the numbers");
        Console.WriteLine("For stop the program enter a \"-1\" number");

        Console.Write("\nEnter an integer positive number ");
        num = int.Parse(Console.ReadLine());

        while (num != -1)
        {
            
            if (num % 2 == 0 && num % 3 == 0)
                mult = mult * num;
            Console.Write("\nEnter an integer positive number ");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The product of the numbers is: {0}", mult);

        Console.ReadKey();
    }
}