using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int n, nRnd, c8 = 0, c9 = 0, c10 = 0, temp = 0, count = 0;
        int max = 0;
        double avg = 0.0;

        Random rnd = new Random();

        Console.Write("Enter amount of numbers: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            nRnd = rnd.Next(8, 11);
            Console.WriteLine(nRnd);
            temp = temp + nRnd;
            count++;
            switch (nRnd)
            {
                case 8: { c8++; } break;
                case 9: { c9++; } break;
                case 10: { c10++; } break;
            }


            //avg = (double)(c8 + c9 + c10) / 3;

            if (c10 != 0)
                max = 10;
            if (c10 == 0 && c9 != 0)
                max = 9;
            if (c10 == 0 && c9 == 0)
                max = 8;

        }

        avg = (double)(temp) / count;

        Console.WriteLine("\n\n\n--------------------------------------------");
        if (c10 > c9 && c10 > c8)
            Console.Write("\nThe lotterey of 10 number would be most\n");
        if (c9 > c10 && c9 > c8)
            Console.Write("\nThe lotterey of 9 number would be most\n");
        if (c8 > c9 && c8 > c10)
            Console.Write("\nThe lotterey of 8 number would be most\n");

        Console.Write("\nThe average is: {0}\n", avg);

        Console.Write("\nThe maximum number is: {0}", max);


        Console.ReadKey();
    }
}