using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת שני מספרים שלמים */
    /* טענת יציאה: הפעולה מדפיסה את המספרים בטווח שביניהם */
    static void Print(int n1, int n2)
    {
        int temp;

        if (n1 > n2)
        {
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        for (int i = n1; i <= n2; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }


    /* קלט: 20 זוגות של מספרים */
    /* פלט: עבור כל זוג, הדפסת כל המספרים שביניהם */
    public static void Main(string[] args)
    {
        int num1, num2;

        Random rnd = new Random();

        for (int i = 1; i <= 20; i++)
        {
            num1 = rnd.Next(0, 21);
            num2 = rnd.Next(0, 21);
            Console.WriteLine("....................................................................\n");
            Print(num1, num2);
        }

        Console.ReadKey();
    }
}