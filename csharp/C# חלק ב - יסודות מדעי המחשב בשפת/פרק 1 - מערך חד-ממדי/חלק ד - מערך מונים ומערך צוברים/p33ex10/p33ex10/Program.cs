using System;

class Program
{
    // קבוע - גודל המערך
    const int N = 71;

    static void Main()
    {

        int[] counter = new int[N]; // מערך מונים
        int i;          // משתנה הלולאה
        int num;        // מספר המתעמלים
        int age;        // גילו של כל מתעמל
        int maxIndex;   // הערך של האיבר המקסימלי במערך

        // לולאה לאיפוס מערך המונים
        for (i = 0; i < N; i++)
            counter[i] = 0;

        Console.WriteLine("Type number of gymnasts ");
        num = int.Parse(Console.ReadLine());
        for (i = 0; i < num; i++)
        {
            age = int.Parse(Console.ReadLine());

            // מניה של כל גיל על-ידי הגדלת ערכו של התא המתאים ב-1
            counter[age]++;
        }

        // (לולאה למציאת הגיל שיש בו הכי הרבה נרשמים (מקסימלי
        maxIndex = 1;
        for (i = 2; i < N; i++)
            if (counter[i] > counter[maxIndex])
                maxIndex = i;

        // הדפסת הגילאים שיש הכי הרבה נרשמים
        Console.WriteLine("The common ages are:");
        for (i = 1; i < N; i++)
            if (counter[i] == counter[maxIndex])
                Console.Write(i + ", ");

        // הדפסת הגילאים שאין להם נרשמים
        Console.WriteLine("The common ages are:");
        for (i = 1; i < N; i++)
            if (counter[i] == 0)
                Console.Write(i + ", ");

        Console.ReadKey();
    }
}