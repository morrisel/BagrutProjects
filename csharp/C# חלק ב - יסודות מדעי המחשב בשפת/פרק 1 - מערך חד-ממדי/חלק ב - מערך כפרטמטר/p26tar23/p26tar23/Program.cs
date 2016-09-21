using System;

class Program
{
    public static void GetArray(int[] arr, int n)
    {
        if (n % 2 == 0)
        {
            for (int i = 0; i < arr.Length; i+=2)
                Console.Write(arr[i] + " ");
        }
        else
        {
            for (int i = 1; i < arr.Length; i+=2)
                Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Random rnd = new Random();
        int[] a = { 2, 3, 5, 7, 18 };
        int num;

        num = rnd.Next(10);

        if (num % 2 == 0)
        {
            GetArray(a, num);
            GetArray(a, num - 1);
        }
        else
        {
            GetArray(a, num);
            GetArray(a, num - 1);
        }

        Console.ReadKey();
    }
}