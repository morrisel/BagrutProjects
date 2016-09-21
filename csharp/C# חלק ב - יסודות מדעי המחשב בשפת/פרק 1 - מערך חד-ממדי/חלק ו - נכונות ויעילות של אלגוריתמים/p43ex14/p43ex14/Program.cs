using System;

class Program
{
    // --------------------- פתרון א
    /* טענת כניסה: הפעולה מקבלת מערך חד-ממדי */
    /* טענת יציאה: הפעולה מחזירה את מיקומו של המקסימלי במערך */
    static int Max1(int[] a)
    {
        int place = 0;

        for (int i = 1; i < a.Length; i++)
            if (a[i] > a[place])
                place = i;

        return place;
    }

    /* טענת כניסה: הפעולה מקבלת מערך ואת מיקומו של האיבר המקסימלי במערך */
    /* טענת יציאה: הפעולה מחזירה את מיקומו של האיבר השני בגודלו במערך */
    static int Max2(int[] a, int j)
    {
        int place;

        if (j != 0)
            place = 0;
        else
            place = 1;

        for (int i = 1; i < a.Length; i++)
            if (a[i] > a[place])
                if (i != j)
                    place = i;

        return place;
    }


    // --------------------- פתרון ב
    /* טענת כניסה: הפעולה מקבלת מערך חד-ממדי */
    /* טענת יציאה: הפעולה מדפיסה את המקסימלי במערך ואת השני בגודלו */
    static void FindBoth(int[] a)
    {
        int place1, place2;

        if (a[0] > a[1])
        {
            place1 = 0;     // התא הראשון הוא המקסימלי הנוכחי
            place2 = 1;     // התא השני הוא השני בגודלו הנוכחי
        }
        else
        {
            place1 = 1;     // התא השני הוא המקסימלי הנוכחי
            place2 = 0;     // התא הראשון הוא השני בגודלו הנוכחי
        }

        for (int i = 2; i < a.Length; i++)
        {
            if (a[i] > a[place1])   // הנוכחי הגדול ביותר
            {
                place2 = place1;    // השני בגודלו הוא הגדול הקודם
                place1 = i;         // הגדול הוא הנוכחי
            }
            else
                if (a[i] > a[place2])   // הנוכחי הוא השני בגודלו
                    place2 = i;         // קטן מהגדול וגדול מהשני
        }

        Console.WriteLine("The first max is: " + a[place1]);
        Console.WriteLine("The second max is: " + a[place2]);

    }


    static void Main()
    {
        // ---------------------------------------------------------- פתרון א
        //int[] arr1 = new int[int.Parse(Console.ReadLine())];
        int place1, place2;

        int[] arr1 = { 11, 2, 13, 3, 17, 5, 19, 7 };

        //for (int i = 0; i < arr1.Length; i++)
        //    arr1[i] = int.Parse(Console.ReadLine());

        place1 = Max1(arr1);
        Console.WriteLine("The first max is: " + arr1[place1]);

        place2 = Max2(arr1, place1);
        Console.WriteLine("The second max is: " + arr1[place2]);

        // ---------------------------------------------------------- פתרון ב
        FindBoth(arr1);


        Console.ReadKey();
    }
}