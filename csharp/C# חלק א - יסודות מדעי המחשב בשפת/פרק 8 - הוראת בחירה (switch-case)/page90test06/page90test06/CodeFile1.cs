using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int day = 0;

        Console.Write("Enter name of week:  ");
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
        Console.WriteLine("It's {0} day of the week", day);
        Console.ReadKey();
    }
}