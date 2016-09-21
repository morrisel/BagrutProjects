using System;

class PrintChar
{
    /* ch ותו num טענת כניסה: הפעולה מקבלת מספר */
    /* פעמיים בשורה אחת num ,ch טענת יציאה: הפעולה מדפיסה את התו */
    static void PrintLine(int num, char ch)
    {
        for (int i = 1; i <= num; i++)
            Console.Write(ch);
        Console.WriteLine("\n\n");
    }

    public static void Main(string[] args)
    {
        int n;
        char sign;

        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Insert character for line {0}", i);
            sign = char.Parse(Console.ReadLine());
            PrintLine(n, sign);
        }

            Console.ReadKey();
    }
}