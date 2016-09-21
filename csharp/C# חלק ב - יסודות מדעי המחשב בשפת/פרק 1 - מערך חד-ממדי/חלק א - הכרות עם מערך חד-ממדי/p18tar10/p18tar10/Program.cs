using System;

class Program
{
    static void Main()
    {
        double avg;
        int[] arr = { 1, 9, 2, 8, 5, 4, 7, 5, 9 };
        int count = 0, sum = 0;

        //---------------------------------- הדפסת ממוצע הערכים במערך
        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
            count++;
        }

        avg = (double)sum / count;
        Console.WriteLine("The average of array is: {0}", avg);

        //---------------------------------- הדפסת מספר הערכים במערך שערכם שונה מהממוצע
        count = 0;
        avg = (int)avg;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != avg)
                count++;
        }

        Console.Write("The different numbers in array value = {0}", count);


        Console.ReadKey();
    }
}