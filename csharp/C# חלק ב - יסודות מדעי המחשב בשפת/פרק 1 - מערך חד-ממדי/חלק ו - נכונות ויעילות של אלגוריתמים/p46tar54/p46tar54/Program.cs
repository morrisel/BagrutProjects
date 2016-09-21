using System;

class Program
{
    public static int GetSetGrpoup(int[] arr)
    {
        int a1 = arr[0];
        int countRange = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (a1 != arr[i])
                countRange++;
            else
                break;
        }

        return countRange;
    }
    public static bool IsSerialArray(int[] arr, int[] partArr, int d)
    {
        int j = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (partArr[j] == arr[i] && (arr.Length % d == 0))
            {
                j++;
                if (j == d)
                    j = 0;
            }
            else
                return false;
        }

        return true;
    }

    public static void Print(int[] arr, int[] partArr, int d)
    {
        
        if (IsSerialArray(arr, partArr, d))
            Console.WriteLine("Serial Array");
        else
            Console.WriteLine("Not Serial Array");
    }
    public static void Print(bool b)
    {
        if (b)
            Console.WriteLine("Serial Array");
        else
            Console.WriteLine("Not Serial Array");
    }
    static void Main()
    {
        //--------------------------------------- דוגמאות למעכים סדרתיים
        //int[] arr = new int[] { 1, 2, 5, 1, 2, 5, 1, 2, 5 };
        //int[] arr = new int[] { 3, 6, 3, 6, 3, 6 };
        //int[] arr = new int[] { 3, 5, 12, 15, 3, 5, 12, 15, 3, 5, 12, 15 };

        //--------------------------------------- דוגמאות למערכים שאינם סדרתיים
        //int[] arr = new int[] { 4, 2, 1, 4, 1, 2, 4, 2, 1 };
        int[] arr = new int[] { 4, 2, 1, 4, 2, 1, 4, 2 };
        int[] partArr;
        int d;
        bool flag;

        d = GetSetGrpoup(arr);
        
        partArr = new int[d];
        for (int i = 0; i < d; i++)
            partArr[i] = arr[i];


        Print(arr, partArr, d);     // first Print method is running...

        flag = IsSerialArray(arr, partArr, d);
        Print(flag);                // second Print methos is running...

        if (IsSerialArray(arr, partArr, d))
            Console.WriteLine("Serial Array");
        else
            Console.WriteLine("Not Serial Array");

        Console.ReadKey();
    }
}