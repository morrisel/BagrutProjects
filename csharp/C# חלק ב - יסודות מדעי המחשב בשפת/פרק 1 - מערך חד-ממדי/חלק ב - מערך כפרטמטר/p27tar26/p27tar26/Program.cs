using System;

class Program
{
    // מחזירה 'אמת' או 'שקר' עבור מחצית הראשונה של המערך
    public static bool LeftSort(int[] leftArr)
    {
        bool isSortedLeft = false;
        int index = 0;

        for (int i = 0; i < leftArr.Length - 1; i++)
        {
            if (leftArr[i] <= leftArr[i + 1])
                index++;

            if (index == leftArr.Length - 1)
                isSortedLeft = true;
        }

        if (isSortedLeft == true)
            return true;
        else
            return false;
    }

    // מחזירה 'אמת' או 'שקר' עבור מחצית השנייה של המערך
    public static bool RightSort(int[] rightArr)
    {
        bool isSortedRight = false;
        int index = 0;

        for (int i = 0; i < rightArr.Length - 1; i++)
        {
            if (rightArr[i] <= rightArr[i + 1])
                index++;

            if (index == rightArr.Length - 1)
                isSortedRight = true;
        }

        if (isSortedRight == true)
            return true;
        else
            return false;
    }

    public static bool SortedArray(int[] arr)
    {
        bool isHalfSorted = false;
        int[] leftArr = new int[arr.Length / 2];
        int[] rightArr = new int[arr.Length / 2];
        int index = 0;

        // השמת ערכים למחצית המערך - השמאלי והימני
        for (int i = 0; i < arr.Length; i++)
        {

            if (i < arr.Length/2)
                leftArr[index] = arr[i];
            else
                if (arr.Length/2 <= i)
                    rightArr[index] = arr[i];

            if (index == arr.Length / 2 - 1)
            {
                index = -1;
            }
            index++;
        }

        if (RightSort(rightArr) == true || LeftSort(leftArr) == true)
            isHalfSorted = true;
        else
            isHalfSorted = false;

        return isHalfSorted;
    }

    static void Main()
    {
        //int[] arr = { 1, 1, 2, 3, 4, 1, 1, 7, 9, 2 };
        int[] arr = { 5, 1, 2, 3, 4, 19, 11, 13, 17, 2 };

        Console.WriteLine(SortedArray(arr));


        Console.ReadKey();
    }
}