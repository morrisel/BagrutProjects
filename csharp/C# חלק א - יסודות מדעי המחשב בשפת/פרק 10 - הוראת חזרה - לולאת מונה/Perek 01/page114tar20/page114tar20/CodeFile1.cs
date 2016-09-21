using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n1, n2, temp;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        if (n1 % 2 != 0)
        {
            n1++;
        }
        for (; n1 < n2; n1 += 2)
        {
            Console.WriteLine(n1);
        }
        Console.ReadKey();
    }
}