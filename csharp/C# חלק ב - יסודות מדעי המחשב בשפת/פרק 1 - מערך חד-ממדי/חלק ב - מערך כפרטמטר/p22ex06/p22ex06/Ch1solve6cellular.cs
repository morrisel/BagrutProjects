using System;

class Ch1solve6cellular
{
    const int N = 31;

    /* טענת כניסה: הפעולה מקבלת מערך */
    /* טענת יציאה: הפעולה מחזירה איברי המערך */
    static double Avg(int[] month)
    {
        double sum = 0.0;

        for (int i = 0; i < N; i++)
            sum += month[i];

        return sum / N;
    }


    static void Main()
    {
        int[] month1 = new int[N];
        int[] month2 = new int[N];
        double avg1, avg2;

        Console.WriteLine("Enter data for the first month");
        for (int i = 0; i < N; i++)
            month1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter data for the second month");
        for (int i = 0; i < N; i++)
            month2[i] = int.Parse(Console.ReadLine());

        avg1 = Avg(month1);
        avg2 = Avg(month2);

        if (avg2 * 1.25 <= avg1)
            Console.WriteLine("yes");
        else
            Console.WriteLine("no");



        Console.ReadKey();
    }
}