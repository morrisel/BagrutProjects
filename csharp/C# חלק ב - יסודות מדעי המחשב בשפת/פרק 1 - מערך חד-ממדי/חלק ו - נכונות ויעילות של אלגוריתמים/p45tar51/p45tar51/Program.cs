using System;

class Program
{
    const int N = 7;

    public static int[] SortArray(int[] arr)
    {
        int temp;
        int count = 1;

        for (int i = 1; i < N * N; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                temp = arr[i - 1];
                arr[i - 1] = arr[i];
                arr[i] = temp;
            }

            if ((i + 1) % N == 0)
            {
                i = 0;
                count++;
            }
            if (count == 7) break;
        }

        return arr;
    }

    static void Main()
    {
        int[] arr = new int[N] { 5, 2, 9, 4, 1, 6, 3 };
        int[] tmura = new int[N];
        bool isTmura = true;

        tmura = SortArray(arr);

        for (int i = 1; i < N; i++)
        {
            if (tmura[i - 1] + 1 != arr[i])
            {
                isTmura = false;
                break;
            }
        }

        if (isTmura)
            Console.WriteLine("Tmura");
        else
            Console.WriteLine("Not Tmura");


        Console.ReadKey();
    }
}