using System;

class Program
{
    static void QuickSort(int[] arr, int left, int right)
    {
        int temp;
        int x = arr[left + (right - left) / 2];

        int i = left;
        int j = right;

        while (i <= j)
        {

            while (arr[i] < x)
                i++;

            while (arr[j] > x)
                j--;

            if (i <= j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                i++;
                j--;
            }
        }

        if (i < right)
            QuickSort(arr, i, right);

        if (left < j)
            QuickSort(arr, left, j);

    }

    static void Main()
    {
        int[] arr = { 2, 8, 20, 4, 7, 15, 18, 1, 11 };

        QuickSort(arr, 0, 4);
    }
}