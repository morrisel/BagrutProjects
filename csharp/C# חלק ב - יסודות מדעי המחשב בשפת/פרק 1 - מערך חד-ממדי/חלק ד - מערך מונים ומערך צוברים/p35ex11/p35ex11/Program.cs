﻿using System;

class Program
{
    const int N = 6;

    /* טענת כניסה: הפעולה קולטת את מספר הילדים בכל משפחה */
    /* טענת יציאה: הפעולה צוברת את מספר הילדים לפי קומות, ומחזירה את המערך הצובר */
    static int[] NumOfChildren()
    {
        int[] a = new int[N];

        int num;
        for (int i = 0; i < a.Length; i++)
            a[i] = 0;

        for (int i = 5; i <= 10; i++)
        {
            Console.WriteLine("Enter num of children in floor " + i);
            for (int j = 0; j < 6; j++)
            {
                num = int.Parse(Console.ReadLine());
                a[i - 5] += num;
            }
        }

        return a;
    }


    /* טענת כניסה: הפעולה מקבלת מערך הילדים לפי קומות */
    /* טענת יציאה: הפעולה מחזירה את הקומה שבה מספר הילדים הוא מקסימלי */
    static int Max1(int[] a)
    {
        int max = 0;
        for (int i = 1; i < a.Length; i++)
            if (a[i] > a[max])
                max = i;

        return max;
    }



    /* קלט: מספר ילדים בכל אחת מ-6 המשפחות ב-5 קומות */
    /* פלט: הקומות בהן מספר הילדים הוא הגדול ביותר */

    static void Main()
    {
        int[] a = NumOfChildren();
        int max = Max1(a);

        Console.WriteLine("The floor are:");
        for (int i = 0; i < a.Length; i++)
            if (a[max] == a[i])
                Console.WriteLine(i + 5);

        Console.ReadKey();
    }
}