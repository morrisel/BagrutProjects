using System;

class CodeFile
{
    static void Main(string[] args)
    {
        int day = 0;
        string strDay = Console.ReadLine();

        switch (strDay)
        {
            case "Sunday": day = 1; break;
            case "Monday": day = 2; break;
            case "Tuesday": day = 3; break;
            case "Wednesday": day = 4; break;
            case "Thursday": day = 5; break;
            case "Friday": day = 6; break;
            case "Saturday": day = 7; break;
        }

        Console.WriteLine(day);
        Console.ReadKey();
    }
}