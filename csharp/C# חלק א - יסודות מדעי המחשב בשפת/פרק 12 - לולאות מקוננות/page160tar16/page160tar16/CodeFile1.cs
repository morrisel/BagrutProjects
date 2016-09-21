using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int block = 0, stack = 0, coin = 0, fake = 0;

        Random rnd = new Random();

        block = rnd.Next(10, 15);

        stack = rnd.Next(1, 11);        // ערמה עם מטבע מזויף
        fake = rnd.Next(1, 11);         // מטבע מזויף

        for (int i = 1; i <= block; i++)        // ערמות
        {
            block = rnd.Next(10, 15);
            int sum = 0;
            for (int j = 1; j <= block; j++)    // מטבעות
            {
                if (i == stack && j == fake)
                {
                    sum = sum + 7;      // מטבע מזויף
                    Console.WriteLine("We have a fake coin in {0} stack", i);
                }
                else
                {
                    if (j == block)
                        sum = sum + 100;
                    else
                        sum = sum + 10;
                }
            }
        }
        Console.ReadKey();
    }
}