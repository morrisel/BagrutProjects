using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n1, n2, i, nMin, nSum = 0, nMult = 1;

        Console.WriteLine("Enter two digit numbers");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if (n1 < n2)
            nMin = n1;
        else
            nMin = n2;

        for (; nMin <= n2; nMin++)
        {
            //accumulations
            nSum = nSum + nMin;
            nMult = nMult * nMin;
        }
        Console.WriteLine("\nThe sum between n1-n2 is: {0}", nSum);
        Console.WriteLine("\nThe multiplies between n1-n2 is: {0}", nMult);
        Console.ReadKey();
    }
}