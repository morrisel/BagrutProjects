using System;

class Program
{
    public static bool BalancedTestForArray(int[] arr)
    {
        double avg;
        int sum = 0;

        // סופר כמות ערכים בערך שמעל הממוצע
        int upperAvgCount = 0;

        // סופר כמות ערכים בערך שמתחת לממוצע
        int lowerAvgCount = 0;

        // מציאת סכום הערכים של המערך
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];

        avg = (double)sum / arr.Length;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < avg)
                lowerAvgCount++;

            if (arr[i] > avg)
                upperAvgCount++;
        }

        if (upperAvgCount == lowerAvgCount)
            return true;        // המערך ממוין
        else
            return false;       // המערך אינו ממוין
    }


    static void Main()
    {
        bool isBalanced;

        // דוגמא למערך מאוזן
        int[] a = { 1, 1, 2, 3, 4, 1, 1, 1, 2, 2 };

        // דוגמא למערך שאינו מאוזן
        int[] b = { 5, 1, 2, 3, 4, 1, 1, 1, 2, 2 };

        isBalanced = BalancedTestForArray(a);
        Console.WriteLine("a[] " + isBalanced);

        isBalanced = BalancedTestForArray(b);
        Console.WriteLine("b[] " + isBalanced);

        Console.ReadKey();
    }
}