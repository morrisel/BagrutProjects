using System;

class Program
{
    /* קלט: נתוני 20 קפיצות */
    /* פלט: מספר התלמידים הכולל ומספרם הסידורי של התלמידים שקפצו מעל הממוצע */
    static void Main()
    {
        double[] heights = new double[20];
        double sum = 0.0, avg;
        int aboveAvg = 0;

        Console.WriteLine("Enter number of jumps");
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = double.Parse(Console.ReadLine());

            // סכום הקפיצות
            sum = sum + heights[i];
        }

        // ממוצע הקפיצות
        avg = sum / (heights.Length);
        Console.WriteLine("The average of jumps is: {0}", avg);

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] > avg)
            {
                aboveAvg++;
                Console.WriteLine("Student number {0} passed the average", i + 1);
            }
        }

        Console.WriteLine("{0} student above average", aboveAvg);

        Console.ReadKey();
    }
}