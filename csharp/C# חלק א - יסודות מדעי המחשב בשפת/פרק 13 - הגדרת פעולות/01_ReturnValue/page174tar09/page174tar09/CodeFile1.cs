using System;

class CodeFile1
{
    // מחלק משותף הקטן ביותר
    /* טענת כניסה: הפעולה מקבלת שני מספרים שלמים */
    /* טענת יציאה: הפעולה מחזירה את המחלק משותף הקטן ביותר */
    static int LCD(int a, int b)        // LCD - Lowest Common Denominator
    {
        int n = 2, min, max, sum;

        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }
        sum = a + b;
        while (min % n != 0 || max % n != 0)
        {
            n = n + 1;
            if (sum == n)
                n = -1;
        }

        return n;
    }

    /* קלט: שני מספרים */
    /* פלט: מחלק משותף הקטן ביותר */
    public static void Main(string[] args)
    {
        int getlcd, x, y;

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("\nEnter two numbers of {0} pair:", i);
            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());

            getlcd = LCD(x, y);

            if (getlcd == -1)
                Console.WriteLine("The pairs {0},{1} does not have the Lowest Common Denominator", x, y);
        }

        Console.ReadKey();
    }
}
