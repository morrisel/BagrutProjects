using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת שני זמנים, שעת תחילה ושעת סיום */
    /* טענת יציאה: הפעולה מחזירה את שעות עבודה יומית */
    static int P2(double startTime, double endTime)
    {
        int hours, minutes;
        int start, end, difference;

        hours = (int)startTime;
        minutes = (int)((startTime - hours) * 100);
        Console.WriteLine("hours for start time working = {0} ", hours);
        Console.WriteLine("minutes for start time working = {0} ", minutes);
        
        start = P1(hours, minutes);
        Console.WriteLine("start time in minutes is {0}\n", start);
        
        hours = (int)endTime;
        minutes = (int)((endTime - hours) * 100);
        Console.WriteLine("hours for end time working = {0} ", hours);
        Console.WriteLine("minutes for end time working = {0} ", minutes);

        end = P1(hours, minutes);
        Console.WriteLine("end time in minutes is {0}", end);

        difference = end - start;
        Console.WriteLine("the difference time is {0}", difference);
        Console.WriteLine("\n...................................\n");
        return difference;
    }

    /* טענת כניסה: הפעולה מקבלת זמן עבודה בשעות ובדקות */
    /* טענת יציאה: הפעולה מחזירה את משך הזמן הכולל בדקות */
    static int P1(int hr, int mn)
    {
        int conv1, conv2, totalMinutes;

        conv1 = hr * 60;
        conv2 = mn;
        totalMinutes = conv1 + conv2;

        return totalMinutes;
    }


    /* קלט: האלגוריתם מקבל כקלט שעת כניסה ושעת יציאה מעבודה */
    /* פלט: האלגוריתם מציג כפלט שעות עבודה המקסימלית שעבד בחודש */
    public static void Main(string[] args)
    {
        double thila, sium;
        int max, diff=0, dayMax = 0;

        thila = double.Parse(Console.ReadLine());
        sium = double.Parse(Console.ReadLine());

        max = P2(thila, sium);

        for (int i = 2; i <= 30; i++)
        {
            thila = double.Parse(Console.ReadLine());
            sium = double.Parse(Console.ReadLine());

            diff = P2(thila, sium);

            if (diff > max)
            {
                max = diff;
                dayMax = i;
            }
        }

        Console.WriteLine("The maximum time of worker in day {0} is {1}", dayMax, max);

        Console.ReadKey();
    }
}