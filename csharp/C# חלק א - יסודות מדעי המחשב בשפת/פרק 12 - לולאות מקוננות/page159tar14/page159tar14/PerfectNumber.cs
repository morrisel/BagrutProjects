using System;

// מספר מושלם
class PerfectNumber
{
    static void Main(string[] args)
    {
        int sum = 1;

        for (int i = 2; i <= 1000; i += 2)
        {
            for (int j = (i / 2); j >= 2; j--)
            {
                if (i % j == 0)
                    sum = sum + j;

                if (sum == i && j == 2)
                    Console.WriteLine(sum);
            }
            //Console.WriteLine("...........");
            sum = 1;
            //Console.WriteLine(sum);
        }
        Console.ReadKey();
    }
}