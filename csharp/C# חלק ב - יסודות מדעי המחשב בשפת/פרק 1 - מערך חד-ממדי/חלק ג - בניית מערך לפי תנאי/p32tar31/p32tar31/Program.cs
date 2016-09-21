using System;

class Program
{
    const int ALen = 8;
    const int BLen = 4;
    static void Main()
    {
        int[] a = { 1, 3, 4, 5, 6, 7, 8, 9, 13 };
        int[] b = { 23, 4, 7, 9, 15 };
        //int[] a = new int[ALen];
        //int[] b = new int[BLen];
        int[] c = new int[b.Length];
        int k = 0;

        //Console.Write("Enter a number for a[] array ");
        //for (int i = 0; i < ALen; i++)
        //    a[i] = int.Parse(Console.ReadLine());

        //Console.Write("Enter a number for b[] array ");
        //for (int i = 0; i < BLen; i++)
        //    b[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                if (b[i] == a[j])
                {
                    c[k] = b[i];
                    k++;
                }
            }
        }

        Console.WriteLine("The c[] array is:");
        for (int i = 0; i < c.Length; i++)
            Console.Write(" " + c[i]);

        Console.ReadKey();
    }
}