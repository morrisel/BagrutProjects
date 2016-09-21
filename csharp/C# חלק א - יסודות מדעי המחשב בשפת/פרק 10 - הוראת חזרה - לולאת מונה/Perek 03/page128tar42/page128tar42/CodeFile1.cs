using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int x, y, numX = 0, countX = 0, numY = 0, countY = 0;
        double avg;

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter a number x of first pairs:  x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter a number y of second pairs: y = ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (x > y)
            {
                Console.WriteLine(x);
                numX = numX + x;
                countX++;
            }
            else
            {
                Console.WriteLine(y);
                numY = numY + y;
                countY++;
            }
            Console.WriteLine("\n");
        }

        avg = (double)(numX + numY) / (countX + countY);
        Console.WriteLine(avg);

        Console.ReadKey();
    }
}