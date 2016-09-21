using System;

class CodeFile1
{
    // מספר משולש
    static void Main(string[] args)
    {
        int nThree, num1, num2, num3, cubic;

        Console.Write("Enter three digit number ");
        nThree = int.Parse(Console.ReadLine());

        num1 = nThree / 100;
        num2 = (nThree % 100) / 10;
        num3 = (nThree % 100) % 10;
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);

        num1 = (int)Math.Pow(num1, 3);      // Cubic root from num1
        num2 = (int)Math.Pow(num2, 3);      // Cubic root from num2
        num3 = (int)Math.Pow(num3, 3);      // Cubic root from num3
        Console.WriteLine();
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);

        cubic = num1 + num2 + num3;

        if (nThree == cubic)
            Console.WriteLine("This is a number of rectangle {0} = {1}", nThree, cubic);
        else
            Console.WriteLine("This is not a number of rectangle {0} != {1}", nThree, cubic);
        
        Console.ReadKey();
    }
}