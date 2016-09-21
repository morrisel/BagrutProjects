using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת שני פרמטרים */
    /* digit טענת יציאה: הפעולה תדפיס את כל המיקומים במספר בהן מופיעה הספרה */
    static void NumAndDigit(int num, int digit)
    {
        int rem, count1 = 0, count2 = 0;

        while (num != 0)
        {
            count1++;
            rem = num % 10;
            num = num / 10;

            if (rem == digit)
            {
                count2++;
                Console.Write("{0} ", count1);
            }
        }

        if (count2 == 0)
            Console.Write("{0} ", count2);
    }


    /* d1-ו n1 קלט: שני מספרים שלמים */
    /* d1 מופיעה הסיפרה n1 פלט: באלו מיקומים של */
    public static void Main(string[] args)
    {
        int n1, d1;

        Console.WriteLine("Enter a number");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a digit of number");
        d1 = int.Parse(Console.ReadLine());

        NumAndDigit(n1, d1);

        Console.ReadKey();
    }
}