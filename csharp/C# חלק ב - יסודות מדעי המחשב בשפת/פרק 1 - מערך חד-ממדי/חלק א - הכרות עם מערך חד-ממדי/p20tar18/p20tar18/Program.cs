using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int[] a = { 9, 5, 1, 5 };
        int[] b = new int[a.Length / 2 * 3];

        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,3} ", a[i]);

        Console.WriteLine("\n");
        for (int i = 0; i < a.Length - 1; i += 2)
        {
            sum = a[i] + a[i + 1];
            if (sum % 3 == 0)
            {
                for (int j = 0; j < 3; j += 3)
                {
                    b[j] = a[i];
                    b[j + 1] = a[i + 1];
                    b[j + 2] = sum;
                    Console.Write("{0,3} {1,3} {2,3}", b[j], b[j + 1], b[j + 2]);
                }
            }
            else
            {
                for (int j = 0; j < 3; j += 3)
                {
                    b[j] = a[i];
                    b[j + 1] = a[i + 1];
                    b[j + 2] = 0;
                    Console.Write("{0,3} {1,3} {2,3}", b[j], b[j + 1], b[j + 2]);
                }
            }
        }

        Console.ReadKey();
    }
}