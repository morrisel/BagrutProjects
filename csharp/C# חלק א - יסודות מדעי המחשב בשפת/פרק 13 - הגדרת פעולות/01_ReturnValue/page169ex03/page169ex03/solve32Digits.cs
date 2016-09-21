using System;

class solve32Digits
{
    /* טענת כניסה: הפעולה מקבלת את הערך המספרי השלם */
    /* טענת יציאה: הפעולה מחזירה את הערך בוליאני */
    static bool EqualDigits(int num)
    {
        if (num / 10 == num % 10)
            return true;
        return false;
    }


    /* קלט: מספר שלם */
    /* פלט: הודעה מתאימה */
    public static void Main(string[] args)
    {
        int num, twoDigits;
        bool found = false;

        Console.WriteLine("Enter a number");
        num = int.Parse(Console.ReadLine());

        found = EqualDigits(num);
        Console.WriteLine("\n\n{0}\n\n", found);

        while (num > 9 && !found)
        {
            twoDigits = num % 100;
            found = EqualDigits(twoDigits);
            num = num / 10;
        }

        if (found)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");





        Console.ReadKey();
    }
}