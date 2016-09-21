using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] a = new int[11];
        int num;

        for (int i = 0; i < 1000; i++)
        {
            num = rnd.Next(1, 11);
            a[num] = a[num] + num / num;
            //a[num-1] += num / num;
        }

        //for (int i = 0; i < 1000; i++)
        //{
        //    num = rnd.Next(1, 13);

        //    if (num <= 10)
        //        a[num - 1] = a[num - 1] + 1;
        //}

        for (int i = 0; i < a.Length; i++)
            Console.Write(a[i] + " ");

        Console.ReadKey();
    }
}