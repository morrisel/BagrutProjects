using System;

/* פלט: האם סכום הערכים הנמצאים במקומות הזוגיים במערך */
/* שווה לסכום הערכים במקומות הזוגיים */
class Program
{
    static void Main()
    {
        // סכום המספרים במקומות האי-זוגיים
        int oddSum = 0;

        // סכום המספרים במקומות הזוגיים
        int evenSum = 0;

        int[] a = { 4, 7, 2, 8, 9, 6, 5, 1, 9, 3 };
        //int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        for (int i = 0; i < a.Length; i++)
        {
            if (i % 2 == 0)
                evenSum = evenSum + a[i];
            else
                oddSum = oddSum + a[i];
        }

        if (evenSum == oddSum)
            Console.WriteLine("The sums is equals");
        else
            Console.WriteLine("The sums isn't equals");


        Console.ReadKey();
    }
}