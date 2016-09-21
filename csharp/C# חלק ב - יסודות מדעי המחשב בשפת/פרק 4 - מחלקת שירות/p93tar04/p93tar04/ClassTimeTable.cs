using System;

class ClassTimeTable
{
    /* הפעולה מאתחלת את מערך מערכת השעות במחרוזות ריקות */
    public static void ResetStudySubject(string[,] timeTable)
    {
        for (int i = 1; i < timeTable.GetLength(0); i++)
        {
            for (int j = 0; j < timeTable.GetLength(1); j++)
            {
                timeTable[i, j] = "";
            }
        }
    }

    /* טענת כניסה: הפעולה מקבלת מערכת שעות, יום, שעה ומקצוע ומעדכנת את המקום המתאים במערכת שעות */
    public static void InsertSubject(string[,] timeTable, int day, int hour, string subject)
    {
        timeTable[hour - 1, day - 1] = subject;
    }

    /* טענת כניסה: הפעולה מקבלת מערכת שעות */
    /* טענת יציאה: הפעולה מחזירה את הקצוע הנלמד באותו יום ובאותה שעה */
    public static string GiveSubject(string[,] timeTable, int day, int hour)
    {
        string[,] table = new string[3, 6];
        string strTemp;
        int row, col;

        row = timeTable.GetLength(0);
        col = timeTable.GetLength(1);

        strTemp = timeTable[hour - 1, day - 1];

        return strTemp;
    }

    /* טענת כניסה: הפעולה מקבלת מערכת שעות ומדפיסה את המערכת בצורת טבלה */
    public static void PrintTimeTable(string[,] timeTable)
    {
        int row, col;

        row = timeTable.GetLength(0);
        col = timeTable.GetLength(1);

        for (int i = 0; i < timeTable.GetLength(0); i++)
        {
            for (int j = 0; j < timeTable.GetLength(1); j++)
            {
                Console.Write("{0,12}", timeTable[i, j]);
            }
            Console.WriteLine();
        }
    }

    /* טענת כניסה: הפעולה מקבלת מערכת שעות ומדפיסה את כל החלונות המופיעים בה. */
    /* .לכל חלון יודפס היום והשעה */
    /* חלון הוא שיעור בתוך יום הלימודים בו לא לומדים, לפניו ואחריו מתקיימים שיעורים */
    public static void PrintTimeTableWindow(string[,] timeTable)
    {
        for (int i = 1; i < timeTable.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < timeTable.GetLength(1); j++)
            {
                if (timeTable[i - 1, j] == "" & timeTable[i + 1, j] == "")
                {
                    Console.WriteLine("{0,4}", timeTable[i, j]);
                }
            }
        }
    }

}



class Program
{
    // ClassTimeTable
    // 1 - void ResetStudySubject ( timeTable )
    // 2 - void InsertSubject ( timeTable, day, hour, subject)
    // 3 - string GiveSubject ( timeTable, day, hour )
    // 4 - void PrintTimeTable ( timeTable )
    // 5 - void PrintTimeTableWindow ( timeTable )
    static void Main()
    {
        string[,] myTable = new string[7, 6];
        string[] str = StudyingCourses.ListOfCourses();
        Random rnd = new Random();
        int num;

        int col, row;
        row = myTable.GetLength(0);
        col = myTable.GetLength(1);
        // 2.
        Console.WriteLine("2. ----------------------------------------------------------------------------------");
        for (int hour = 1; hour <= row; hour++)
        {
            for (int day = 1; day <= col; day++)
            {
                num = rnd.Next(11);
                ClassTimeTable.InsertSubject(myTable, day, hour, str[num]);
            }
        }
        ClassTimeTable.PrintTimeTable(myTable);

        // 3.
        Console.WriteLine("3. ----------------------------------------------------------------------------------");
        string subject;
        int d = 1;
        int h = 6;
        Console.Write("Enter a day: ");
        d = int.Parse(Console.ReadLine());

        Console.Write("Enter an hour: ");
        h = int.Parse(Console.ReadLine());

        subject = ClassTimeTable.GiveSubject(myTable, d, h);
        Console.WriteLine("myTable[{0},{1}] = {2}", h, d, subject);

        // 4.
        Console.WriteLine("4. ----------------------------------------------------------------------------------");
        ClassTimeTable.PrintTimeTable(myTable);

        // 5.
        Console.WriteLine("5. ----------------------------------------------------------------------------------");
        ClassTimeTable.PrintTimeTableWindow(myTable);
        
        Console.ReadKey();
    }
}