using System;

class Program
{
    static void Main()
    {
        int max, min, count = 0;
        int[] arr = { 4, 9, 2, 8, 5, 6, -2, 3, 9 };
        int[] indexArr = new int[arr.Length];

        Console.Write("arr: ");
        for (int i = 0; i < arr.Length; i++)
            Console.Write("{0,3}", arr[i]);

        max = arr[0];
        min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }

            if (arr[i] >= max)
            {
                max = arr[i];
                count++;
                indexArr[i] = i;
            }
        }

        Console.WriteLine("\n");
        // הדפסת המספר המינימלי והמספר המקסימלי
        Console.WriteLine("The mininmum value of array is:\t\t{0}", min);
        Console.WriteLine("The maximum value of array is:\t\t{0}", max);

        // הדפסת מספר ההופעות של המספר המקסימלי במערך
        Console.WriteLine("The max numbers value of array is:\t{0}", count - 1);

        // הדפסת המציינים של המספר המקסימלי במערך
        Console.Write("The index of max value they are:\t");
        for (int i = 0; i < indexArr.Length; i++)
            if (indexArr[i] != 0)
                Console.Write("{0} ",i);

        Console.ReadKey();
    }
}