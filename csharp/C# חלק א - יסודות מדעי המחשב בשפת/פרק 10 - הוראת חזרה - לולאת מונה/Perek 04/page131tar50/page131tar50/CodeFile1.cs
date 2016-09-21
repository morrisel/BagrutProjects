using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double dNum, maxTemp2, maxTemp1, max;
        int temp1, temp2;

        Console.WriteLine("The program is find a max fraction number\n");

        Console.Write("Enter a number: ");
        dNum = double.Parse(Console.ReadLine());

        temp1 = (int)dNum;
        maxTemp1 = dNum - temp1;

        max = maxTemp1 + temp1;

        for (int i = 2; i <= 10; i++)
        {
            Console.Write("Enter a number: ");
            dNum = double.Parse(Console.ReadLine());
            temp2 = (int)dNum;
            maxTemp2 = dNum - temp2;

            if (maxTemp2 > maxTemp1)
            {
                maxTemp1 = maxTemp2;
                max = maxTemp1 + temp2;
            }

        }

        Console.WriteLine("\n\nThe max fraction of number is: {0}", max);


        Console.ReadKey();
    }
}