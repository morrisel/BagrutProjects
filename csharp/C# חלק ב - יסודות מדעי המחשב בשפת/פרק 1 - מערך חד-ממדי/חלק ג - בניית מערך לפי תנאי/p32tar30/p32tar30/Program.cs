using System;

class Program
{
    const int N = 8;

    static void Main()
    {
        int[] numbers = { 1, 2, 3, -4, 5, 6, -7, 8 };

        // מערך שיכיל את המספרים הזוגיים
        int[] evenNumbers = new int[N];

        // מערך שיכיל את המספרים השליליים
        int[] negativeNumbers = new int[N];

        int m = 0, n = 0;

        for (int i = 0; i < N; i++)
        {
            if (numbers[i] % 2 == 0 && numbers[i] > 0)
            {
                evenNumbers[m] = numbers[i];
                m++;
            }
            else if (numbers[i] < 0)
            {
                negativeNumbers[n] = numbers[i];
                n++;
            }
        }

        Console.WriteLine("#even");
        for (int i = 0; i < N; i++)
            Console.Write(evenNumbers[i] + " ");

        Console.WriteLine("\n#negative");
        for (int i = 0; i < N; i++)
            Console.Write(negativeNumbers[i] + " ");


        Console.ReadKey();
    }
}