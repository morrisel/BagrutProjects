using System;

class Program
{
    const int N = 8;
    static void Main()
    {
        int[] grd1 = new int[N] { 80, 60, 40, 96, 95, 55, 50, 100 };
        int[] grd2 = new int[N] { 80, 70, 50, 99, 100, 60, 50, 100 };
        int[] grd3 = new int[N];

        int j=0;

        //for (int i = 0; i < N; i++)
        //{
        //    Console.Write("Enter the first grade for student " + (i + 1));
        //    grd1[i] = int.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < N; i++)
        //{
        //    Console.Write("Enter the second grade for student " + (i + 1));
        //    grd2[i] = int.Parse(Console.ReadLine());
        //}

        for (int i = 0; i < N; i++)
        {
            if ((grd1[i] + grd2[i]) / 2 < 60)
            {
                grd3[j] = i + 1;
                j++;
            }
        }

        for (int i = 0; i < N; i++)
        {
            Console.Write(grd3[i] + " ");
        }


        Console.ReadKey();
    }
}