using System;

class CodeFile1
{
    /* קלט: תאריך - יום, חודש ושנה */
    /* פלט: הודעה האם התאריך שהוזן נכון או לא נכון */
    static void Main(string[] args)
    {
        int day, month, year;
        bool db = false, mb = false, yb = false;

        Console.Write("Enter a number of day: ");
        day = int.Parse(Console.ReadLine());
        Console.Write("Enter a number of month: ");
        month = int.Parse(Console.ReadLine());
        Console.Write("Enter a number of year: ");
        year = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // 4, 6, 9, 11 - 30 days
        // 1, 3, 5, 7, 8, 10, 12 - 31 days
        // 2 - 28 days or 29 days
        switch (month)
        {
            case 2:
                {
                    mb = true;
                    if ((day >= 1 && day <= 28) && (year >= 1000))
                    {
                        db = true;
                        yb = true;
                    }
                }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                {
                    mb = true;
                    if ((day >= 1 && day <= 28) && (year >= 1000))
                    {
                        db = true;
                        yb = true;
                    }
                }
                break;
            default:
                {
                    mb = true;
                    if ((day >= 1 && day <= 28) && (year >= 1000))
                    {
                        db = true;
                        yb = true;
                    }
                }
                break;
        }

        Console.WriteLine("test...");

        Console.WriteLine(db);
        Console.WriteLine(mb);
        Console.WriteLine(yb);

        if (db && mb && yb)
            Console.WriteLine("The date is {0}/{1}/{2} and it's true", day, month, year);
        else
            Console.WriteLine("Date is false");

        Console.ReadKey();
    }
}