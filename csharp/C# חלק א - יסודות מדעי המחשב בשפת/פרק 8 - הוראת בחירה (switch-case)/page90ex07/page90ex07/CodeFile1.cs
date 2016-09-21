using System;

class CodeFile
{
    static void Main(string[] args)
    {
        double salary, avgPerDay;
        int month, day1, day2;

        Console.WriteLine("Enter your salary in the last month");
        salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the last month 1-12 January->1, February->2,...");
        month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 4:
            case 6:
            case 9:
            case 11: day1 = 30;
                break;
            case 2: day1 = 28;
                break;
            default: day1 = 31;
                break;
        }

        day2 = day1 - 8;
        Console.WriteLine("In this month you work " + day1 + " - 8 = " + day2 + " days ");
        avgPerDay = salary / day2;
        Console.WriteLine("You earned " + avgPerDay + " on average per day ");

        Console.ReadKey();
    }
}