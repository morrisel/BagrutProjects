using System;

class Solve1SumOfDigits
{
    /* טענט כניסה: הפעולה מקבלת מספר שלם */
    /* טענת יציאה: הפעולה מחזירה את סכום ספרותיו */
    static int DigitsSum(int num)
    {
        int digSum = 0;

        while (num > 0)
        {
            digSum = digSum + num % 10;
            num = num / 10;
        }
        return digSum;
    }


    /* קלט: 2 מספרים שלמים */
    /* פלט: המספר שסכום ספרותיו גדול יותר */
    static void Main(string[] args)
    {
        int n1, n2, sum1, sum2;

        Console.WriteLine("Please enter 2 numbers");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        sum1 = DigitsSum(n1);
        sum2 = DigitsSum(n2);

        if (sum1 > sum2)
            Console.WriteLine("The big sum belong to number {0}", sum1);
        else
        {
            if (sum2 > sum1)
                Console.WriteLine("The big sum belong to number {0}", sum2);
            else
                Console.WriteLine("The numbers have equal sum");
        }
        Console.ReadKey();
    }
}