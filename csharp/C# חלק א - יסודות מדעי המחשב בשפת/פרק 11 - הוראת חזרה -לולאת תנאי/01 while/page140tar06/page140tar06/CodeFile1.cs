using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, max = 0, tens, units;

        Console.WriteLine("\nThe program search a max two digit number\n");
        Console.WriteLine("To stop the program press 0\n\n\n");

        Console.Write("Enter a number ");
        num = int.Parse(Console.ReadLine());
        max = num;
        
        while (num != 0)
        {
            tens = num / 10;
            units = num % 10;
            if (num > max && (tens != units))
                    max = num;

            Console.Write("Enter a number ");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n\nThe max number is: {0}", max);
        
        Console.ReadKey();
    }
}