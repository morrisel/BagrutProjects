using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת מספר ותו */
    /* טענת יציאה: הפעולה מדפיסה את התו כמספר */
    static void PrintTriangle(int n, char c)
    {
        for (int i = 1; i <= n; i++)
            Console.Write(c);
    }


    /* קלט: מספר שורות במשולש ותו הרצוי */
    /* פלט: משולש שווה שוקיים מאותו התו */
    public static void Main(string[] args)
    {
        int num, spaces, sign;
        char ch;

        Console.WriteLine("Insert N0. of lines");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose a character");
        ch = char.Parse(Console.ReadLine());

        for (int j = 1; j <= num; j++)
        {
            spaces = num - j;
            PrintTriangle(spaces,' ');
            sign = j * 2 - 1;
            PrintTriangle(sign, ch);
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}