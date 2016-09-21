using System;

// הספרה הקטנה במספר
class CodeFile1
{
    static void Main(string[] args)
    {
        int num, min;

        Console.WriteLine("The programm is stop running when user enter a not three-digit number\n");

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        min = num % 10;

        for (int i = num; (i >= 100 && i < 1000); i = num)
        {
            for (int j = 1; j <= 3; j++)
            {
                i = num % 10;
                if (min > i)
                    min = i;
                num = num / 10;
            }
            Console.WriteLine("The mininmum digit of number is {0} ", min);
            Console.Write("\nEnter a number: ");
            num = int.Parse(Console.ReadLine());
            min = num % 10;
        }
        Console.ReadKey();
    }
}