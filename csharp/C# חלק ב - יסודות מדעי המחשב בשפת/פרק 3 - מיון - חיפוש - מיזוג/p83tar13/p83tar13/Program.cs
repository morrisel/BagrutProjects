using System;

class Program
{
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static int TernarySearch(int[] a, int value)
    {
        int first = 0, second = a.Length - 1, middleBetween;

        middleBetween = (first + second) / 3;
        while (first <= second)
        {
            if (value == a[middleBetween])
            {
                return middleBetween;
            }
            else
            {
                if (value < a[middleBetween])
                {
                    second = middleBetween - 1;
                }
                else
                {
                    first = middleBetween + 1;
                    second = middleBetween * 2 + 1;
                    //if (value > a[middleBetween] && value< a[middleBetween * 2])
                    //{
                    //    second = middleBetween + 1;
                    //    middleBetween = middleBetween * 2;
                    //}
                    //else
                    //{
                    //}
                }
            }

            middleBetween = (first + second) / 2;
        }

        return -1;
    }



    static void Main()
    {
        //int[] a = { 11, 22, 35, 44, 51, 56, 71, 80, 83, 87, 90, 92 };
        int[] a = { 4, 5, 7, 13, 20, 34, 37, 40, 45, 48, 55, 61, 70, 73, 85, 86, 88, 92, 93, 98, 105, 130, 135, 143 };
        int value, answer;

        value = int.Parse(Console.ReadLine());
        answer = TernarySearch(a, value);

        Console.ReadKey();
    }
}