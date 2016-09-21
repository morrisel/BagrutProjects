using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int numCandle, countCandle = 0, countDay = 0, day;

        Console.Write("Enter the number of days of Hanuka (1-8 days) ");
        day = int.Parse(Console.ReadLine());

        for (int i = 1; i <= day; i++)
        {
            countDay++;
            countCandle = countCandle + i;
        }

        numCandle = countCandle + countDay;

        Console.WriteLine(numCandle);

        Console.ReadKey();
    }
}