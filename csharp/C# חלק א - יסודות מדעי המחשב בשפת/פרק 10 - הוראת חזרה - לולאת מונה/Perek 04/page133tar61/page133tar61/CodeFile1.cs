using System;


// Perfect Number - The number is named the "Perfect-number" if "Perfect-number" equals of sum of divisor of the "perfect-number".
class CodeFile1
{
    static void Main(string[] args)
    {
        int num = 0, an, sn = 0;

        num = int.Parse(Console.ReadLine());

        for (int i = num; i <= num && i >= 2; i--)
        {
            if (num % i == 0)
            {
                an = num / i;
                sn = sn + an;
            }
        }

        if (sn == num)
        {
            for (int i = num; i <= num && i > 2; i--)
            {
                if (num % i == 0)
                {
                    Console.Write(" {0} + ", num / i);
                }
            }
            Console.Write(" {0} = {1}", sn / 2, sn);
        }
        Console.ReadKey();
    }
}