using System;

class CodeFile1
{
    /* num טענת כניסה: הפעולה מקבלת מספר חיובי שלם */
    /* num שסכום ספרותיהם שווה לסכום הספרות של num-טענת יציאה: הפעולה מציגה את כל המספרים הקטנים מ */
    static void SumNumber(int num)
    {
        for (int i = 1; i < num; i++)
            Console.WriteLine(i);
    }

    /* n טענת הכניסה: הפעולה מקבלת מספר שלם */
    /* n טענת יציאה: הפעולה מחזירה את סכום הספרות של */
    static int SumDigits(int num)
    {
        int rem, sum = 0;

        while (num != 0)
        {
            rem = num % 10;
            sum = sum + rem;
            num = num / 10;
        }
        return sum;
    }


    /* n קלט: מספר שלם חיובי */
    /* n מציגה את כל המספרים הקטנים מסכום הספרות של SumNumber פלט: הפעולה */
    public static void Main(string[] args)
    {
        int sumDig, n;

        n = int.Parse(Console.ReadLine());

        // n מקבל סכום הספרות sumDig המשתנה
        sumDig = SumDigits(n);
        
        SumNumber(sumDig);

        Console.ReadKey();
    }
}