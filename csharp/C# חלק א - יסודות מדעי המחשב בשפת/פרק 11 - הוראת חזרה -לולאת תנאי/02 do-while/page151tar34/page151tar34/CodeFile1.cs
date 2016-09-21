using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int rndx, x1 = 30, x2 = 70;
        int dig1, dig2, num, count = 0;
        bool flg = false;

        Random rnd = new Random();

        do
        {
            num = rnd.Next(1000, 10000);

            dig1 = num / 100;
            dig2 = num % 100;
            Console.Write("\n{0} - {1} {2}", num, dig1, dig2);

            if (dig1 == dig2)
            {
                count++;
                Console.WriteLine("  **********   {0}   **********", count);
            }

            // Searching engine for x1 and x2 was created
            rndx = rnd.Next(-5, 6);
            x1 = x1 + rndx;
            rndx = rnd.Next(-5, 6);
            x2 = x2 + rndx;

            if (x1 == x2)
                flg = true;
        }
        while (!flg);

        Console.WriteLine("\n\n");
        Console.WriteLine(count);

        Console.ReadKey();
    }
}