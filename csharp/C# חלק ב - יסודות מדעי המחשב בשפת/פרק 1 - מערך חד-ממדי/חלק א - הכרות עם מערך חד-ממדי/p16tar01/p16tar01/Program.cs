using System;

class Program
{
    static void Main()
    {
        int[] m = { 0, 0, 0, 0 };
        int m1, m2;

        Console.WriteLine("Enter four numbers");
        m[0] = int.Parse(Console.ReadLine());
        m[1] = int.Parse(Console.ReadLine());
        m1 = int.Parse(Console.ReadLine());
        m2 = int.Parse(Console.ReadLine());

        m[1] = 10 * m[1];
        m[2] = m1 + m2;
        m[3] = m[1] + m[2] + m[3];

        //-------------------------- output
        //Console.Write("\nm:");
        //for (int i = 0; i < m.Length; i++)
        //    Console.Write(" {0}", m[i]);

        //Console.WriteLine();
        //Console.WriteLine("m1 = {0}, m2 = {1}", m1, m2);

        Console.ReadKey();
    }
}