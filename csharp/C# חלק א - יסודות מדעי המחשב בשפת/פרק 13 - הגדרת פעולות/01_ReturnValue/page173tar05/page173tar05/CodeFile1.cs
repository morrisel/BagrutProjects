using System;

class CodeFile1
{
    /* טענת כניסה: פעולה מקבלת ספרה (0-9) ומספר שלם חיובי */
    /* טענת יציאה: הפעולה מחזירה מספר הפעמים שהספרה מופיעה במספר */
    static int ShowDigits(int a, int num)
    {
        int count = 0;

        while (num % 10 != 0)
        {
            if (num % 10 == a)
                count++;
            num = num / 10;
        }

        return count;
    }


    /* קלט: ספרה אחת בין (0-9) ומספר טבעי כלשהו */
    /* פלט: מספר ההופעות של הספרה במספר */
    static void Main(string[] args)
    {
        int x, y;
        int sd;     // shows how much digits in the number - (sd = show digits)

        Console.Write("\nEnter a number between (0-9): ");
        x = int.Parse(Console.ReadLine());
        
        Console.Write("Enter an integer positive number: ");
        y = int.Parse(Console.ReadLine());

        sd = ShowDigits(x, y);

        Console.WriteLine("\n The {0} digit appear {1} times", x, sd);

        Console.ReadKey();
    }
}