using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num1, num2, a1, a2, xMin = 0, yMin = 0;
        int numX = 0, numY = 0, min = 0;
        int velocity, time, speed = 10000, numOfCar;
        bool match;

        Console.Write("enter the race-car number:\t\t\t");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("enter the time (min) for the car for finish:\t");
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

            Console.Write("\nenter the race-car number:\t\t\t");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("enter the time (min) for the car for finish:\t");
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

        time = min;
        velocity = speed / time;

        if (xMin < yMin)
            numOfCar = xMin;
        else
            numOfCar = yMin;

        Console.WriteLine("\n------------------------------------\n");
        Console.WriteLine("velocity is: {0}", velocity);
        Console.WriteLine("the number of car is: {0}", numOfCar);

        Console.ReadKey();
    }
}