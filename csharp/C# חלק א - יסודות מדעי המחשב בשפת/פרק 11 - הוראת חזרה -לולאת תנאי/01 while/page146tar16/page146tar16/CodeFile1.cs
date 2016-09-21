using System;

class CodeFile1
{
    /* קלט: מספר שלם חיובי */
    /* פלט: 1. מספר הספרות,  2. סכום הספרות,  3. מכפלת הספרות */
    static void Main(string[] args)
    {
        int num, sum = 0, count = 0, mult = 1;

        Console.WriteLine("Enter an integer number");
        num = int.Parse(Console.ReadLine());

        if (num == 0)
        {
            count++;
            Console.WriteLine("The number of digits is\t\t{0}", count);
            Console.WriteLine("The sum of digits is\t\t{0}", sum);
            Console.WriteLine("The product of digits is\t{0}", num * sum);
        }
        else
        {
            while (num != 0)
            {
                count++;
                sum = sum + num % 10;
                mult = mult * (num % 10);
                num = num / 10;
            }
            Console.WriteLine("The number of digits is\t\t{0}", count);
            Console.WriteLine("The sum of digits is\t\t{0}", sum);
            Console.WriteLine("The product of digits is\t{0}", mult);
        }

        Console.ReadKey();
    }
}