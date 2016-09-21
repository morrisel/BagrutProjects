using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double num, sum = 0, avg;
        int numCount = 0;

        Console.WriteLine("Enter a number -1 for End");
        num = double.Parse(Console.ReadLine());

        while (num != -1.0)         // המספר 1- הוא הזקיף
        {
            numCount = numCount + 1;
            sum = sum + num;
            num = double.Parse(Console.ReadLine());
        }

        avg = sum / numCount;
        Console.WriteLine("The number of values is:\t{0}", numCount);
        Console.WriteLine("The sum of values is:\t\t{0}", sum);
        Console.WriteLine("The average is:\t\t\t{0}", avg);

        Console.ReadKey();
    }
}