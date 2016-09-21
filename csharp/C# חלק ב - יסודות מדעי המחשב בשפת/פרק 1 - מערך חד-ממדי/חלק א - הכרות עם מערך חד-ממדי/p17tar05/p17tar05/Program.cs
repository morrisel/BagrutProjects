using System;

class Program
{
    static void Main()
    {
        int[] num = new int[5];
        int x = 2;

        for (int i = 0; i < num.Length; i++)
            num[i] = x * (i + 1);

        for (int i = 0; i < num.Length; i++)
            Console.Write(" {0}", num[i]);

        //------------------------------- second way
        //for (int i = 0; i < num.Length; i++)
        //{
        //    num[i] = x * (i + 1);
        //    Console.Write("{0} ", num[i]);
        //}
        
        Console.ReadKey();
    }
}