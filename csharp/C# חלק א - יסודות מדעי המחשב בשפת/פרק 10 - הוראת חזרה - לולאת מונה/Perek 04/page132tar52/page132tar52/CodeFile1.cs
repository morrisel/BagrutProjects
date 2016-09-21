using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num1, num2, a1, a2, xMin = 0, yMin = 0;
        int numX = 0, numY = 0, min=0;
        //int multi = 1, count = 0, countX = 0, countY = 0;
        bool match;

        Console.WriteLine("enter two numbers");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        a1 = num1;
        a2 = num2;
        match = ((a1 == num1) && (a2 == num2));

        for (int i = 2; i <= 5; i++)
        {
            if (match)
            {
                xMin = num1;
                yMin = num2;
            }

            Console.WriteLine("\nEnter two numbers of pair");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 < xMin)
                xMin = num1;

            if (num2 < yMin)
                yMin = num2;

            if ((xMin != yMin) && (xMin < yMin))
            {
                min = xMin;
                numX = num1;
                numY = num2;
                xMin = numX;
                yMin = numY;
            }
            else
            {
                if (xMin == yMin)
                {
                    min = xMin;
                    numX = xMin;
                    numY = yMin;
                    xMin = numX;
                    yMin = numY;
                }

                if (yMin < xMin)
                {
                    min = yMin;
                    numX = xMin;
                    numY = yMin;
                    xMin = numX;
                    xMin = numY;
                }
            }
        }
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Minimum number is: {0}", min);
        Console.WriteLine("Pair is: ({0},{1})", numX, numY);

        Console.ReadKey();
    }
}