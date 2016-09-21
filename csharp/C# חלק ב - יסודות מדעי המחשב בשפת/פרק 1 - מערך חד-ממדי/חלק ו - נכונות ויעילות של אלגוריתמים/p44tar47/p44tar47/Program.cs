using System;

class Program
{
    static void Main()
    {
        int[] a1 = { 1, 3, 2, 4, 9 };
        int[] a2 = { 2, 1, 3, 1 };
        int[] a3 = new int[5];

        int i = 0, j = 0, mult = 1;

        while (i < a1.Length)
        {
            mult = a1[i] * a2[j];
            a3[i] = a3[i] + mult;
            j++;

            if (j == a2.Length)
            {
                j = 0;
                i++;
            }
        }

        for (int k = 0; k < a3.Length; k++)
        {
            Console.WriteLine("a3[{0}] = {1}", k, a3[k]);
        }

        Console.ReadKey();
    }
}