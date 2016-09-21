using System;

class CodeFile1
{
    /* קלט: תאריך - יום, חודש ושנה */
    /* פלט: הדפסת הודעה תאריך של יום המחר */
    static void Main(string[] args)
    {
        int day, month, year, numOfDays;

        Console.Write("Enter a number of day: ");
        day = int.Parse(Console.ReadLine());
        Console.Write("Enter a number of month: ");
        month = int.Parse(Console.ReadLine());
        Console.Write("Enter a number of year: ");
        year = int.Parse(Console.ReadLine());

        // 4, 6, 9, 11 - 30 days
        // 1, 3, 5, 7, 8, 10, 12 - 31 days
        // 2 - 28 days or 29 days
        switch (month)
        {
            case 2:
                if ((((year % 4) == 0) && ((year % 100) != 0)) || ((year % 400) == 0))    // leap year
                {
                    numOfDays = 29;
                }
                else
                {
                    numOfDays = 28;
                }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                numOfDays = 30;
                break;
            default: numOfDays = 31;
                break;
        }

        if (day != numOfDays)
            day = day + 1;
        else
        {
            day = 1;
            if (month == 12)
            {
                month = 1;
                year = year + 1;
            }
            else
                month = month + 1;
        }

        Console.WriteLine("\nThe day of tomorrow is {0}/{1}/{2}", day, month, year);

        Console.ReadKey();
    }
}