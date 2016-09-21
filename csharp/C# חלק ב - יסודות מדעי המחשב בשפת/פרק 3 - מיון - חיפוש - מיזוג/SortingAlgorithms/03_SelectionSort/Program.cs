using System;

class Program
{
    static void Sort(int[] arr)
    {
        Sort(arr, 0);
    }

    static void Sort(int[] arr, int start)
    {
        if (start == arr.Length)
            return;

        int min = start;
        for (int i = start + 1; i < arr.Length; i++)
            if (arr[i] < arr[min])
                min = i;
        int tmp = arr[start];
        arr[start] = arr[min];
        arr[min] = tmp;

        Sort(arr, start + 1);
    }

    public static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);

        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };

        Console.WriteLine("Original Array:");
        Print(arr);

        //Sort(arr);
        Sort(arr, 5);

        Console.WriteLine("After Sort:");
        Print(arr);

        Console.ReadKey();
    }
}



//using System;

//class Program
//{
//    static int[] SortByChoose(int[] a, int max, int left)
//    {
//        int k;

//        for (int i = max - 1; i > 0; i--)
//        {
//            k = i; left = a[i];
//            for (int j = 0; j < i; j++)
//            {
//                if (a[j] > left)
//                {
//                    k = j;
//                    left = a[j];
//                }
//            }
//            a[k] = a[i];
//            a[i] = left;
//        }

//        return a;
//    }

//    public static void Print(int[] a)
//    {
//        for (int i = 0; i < a.Length; i++)
//            Console.Write("{0,4}", a[i]);

//        Console.WriteLine();
//    }

//    static void Main()
//    {
//        int n = 9;
//        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };
//        int[] sortArray = new int[n];


//        Console.WriteLine("Original Array:");
//        Print(arr);

//        sortArray = SortByChoose(arr, n, 0);

//        Console.WriteLine("After Sort:");
//        Print(arr);


//        Console.ReadKey();
//    }
//}
