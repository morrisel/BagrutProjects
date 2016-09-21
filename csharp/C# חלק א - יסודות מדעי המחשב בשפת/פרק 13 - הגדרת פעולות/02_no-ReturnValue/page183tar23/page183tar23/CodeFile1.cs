using System;

class CodeFile1
{
    /* (טענת כניסה: הפעולה מקבלת שער הדולר ביום המסחר הקודם ואת שיעור השינוי (באחוזים */
    /* טענת יציאה: הפעולה תחזיר את שער הדולר ביום המסחר הנוכחי */
    static double DollarRate(double rate, double change)
    {
        if (change > 0)
            rate = rate + change;
        else
            rate = rate + change;

        return rate;
    }

    /* טענת כניסה: הפעולה מקבלת שני פרמטרים, שער הדולר ואת יום */
    /* טענת יציאה: הפעולה מציגה את שער הדולר היומי */
    static void TranslationRate(int i, double watch)
    {
        Console.Write("\nThe daily rate of dollar in {0} day is: {1}\n", i, watch);
        Console.WriteLine("\n.........................................................\n");
    }

    /* טענת כניסה: הפעולה מקבלת שני פרמטרים, סכום הכולל ברכישה ואת סכום לאחר 10 ימים */
    /* טענת יציאה: הפעולה מציגה את ההפרש מיום הקניה עד ליום העשירי מיום הקניה */
    static void Comparison(double before, double after)
    {
        if (before > after)
            Console.Write("\nYou was loss in the trade, the {0} in difference of deal\n", before - after);

        if (before < after)
            Console.Write("\nYou was win in the trade, the {0} in difference of deal\n", after - before);
    }


    /* קלט: מספר דולר ושער הדולר */
    /* פלט: הפרש בין יום הרכישה עד יום העשירי */
    public static void Main(string[] args)
    {
        int dollars;
        double rateDollar, dailyChange;
        double sumBefore, sumAfter;

        // מספר הדולרים
        Console.Write("\nEnter the number of dollars: ");
        dollars = int.Parse(Console.ReadLine());

        // ערך הדולר
        Console.Write("\nEnter value of dollar: ");
        rateDollar = double.Parse(Console.ReadLine());

        Console.WriteLine("\n{0} dollars for {1} rate it is buying\n", dollars, rateDollar);
        sumBefore = dollars * rateDollar;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nEnter a daily changing of dollar ");
            dailyChange = double.Parse(Console.ReadLine());

            rateDollar = DollarRate(rateDollar, dailyChange);
            TranslationRate(i,rateDollar);
        }

        sumAfter = dollars * rateDollar;

        Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        Comparison(sumBefore, sumAfter);
        Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

        Console.ReadKey();
    }
}