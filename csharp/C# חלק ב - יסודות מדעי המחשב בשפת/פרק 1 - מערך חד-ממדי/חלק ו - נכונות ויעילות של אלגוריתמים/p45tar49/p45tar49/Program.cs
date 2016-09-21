using System;

class Program
{
    static int MaxSequence(int[] arr)
    {

        int[] arrNumber = new int[8];
        int[] maxSequence = new int[8];
        int tempCount = 1, count = 1;
        int j = 0, maxNumber = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                tempCount++;
            }
            else
            {
                if (tempCount >= count)
                {
                    count = tempCount;
                    arrNumber[j] = arr[i - 1];
                    maxSequence[j] = count;
                    tempCount = 1;
                    j++;
                }
            }
        }

        for (int i = 1; i < maxSequence.Length; i++)
        {
            if (maxSequence[i - 1] < maxSequence[i])
                maxNumber = arrNumber[i];

        }
        return maxNumber;
    }


    static void PringNumber()
    {

    }

    static void Main()
    {
        int[] arr = { 2, 2, 1, 7, 7, 7, 7, 5 };
        int max = 0;
        max = MaxSequence(arr);

        Console.WriteLine("The number of biggest sequence is: {0}", max);
        Console.ReadKey();
    }
}