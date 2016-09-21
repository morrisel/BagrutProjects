using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        /*
        double num;
        Random rnd = new Random();
        num = rnd.Next(1, 40);
        Console.WriteLine(num);
        */

        Console.WriteLine(Math.Sqrt(16));                                   // 1/
        Console.WriteLine(Math.Abs(9 - 16));                                // 2
        Console.WriteLine((int)2.94);                                       // 3
        Console.WriteLine(Math.Sqrt((15 % 5) * 5 + 9));                     // 4/
        Console.WriteLine(Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2)));      // 5
        Console.WriteLine((int)(7.9) * 7);                                  // 6
        Console.WriteLine(Math.Pow(388 / 100, 2) - 1);                      // 7/
        Console.WriteLine(Math.Abs(-15) - (int)(14.5));                     // 8
        Console.WriteLine(Math.Max(36 / 10 % 2, 6));                        // 9

        Console.WriteLine();

        int row1, row2, row3, column1, column2, column3;
        int digLtoR, digRtoL;

        row1 = (int)(Math.Sqrt(16) + Math.Abs(9 - 16) + (int)2.94);
        row2 = (int)(Math.Sqrt((15 % 5) * 5 + 9) + Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2)) + (int)(7.9) * 7);
        row3 = (int)((Math.Pow(388 / 100, 2) - 1) + (Math.Abs(-15) - (int)(14.5)) + Math.Max(36 / 10 % 2, 6));

        Console.WriteLine("The sum of Row 1 = {0}", row1);
        Console.WriteLine("The sum of Row 2 = {0}", row2);
        Console.WriteLine("The sum of Row 3 = {0}", row3);

        Console.WriteLine();

        column1 = (int)((Math.Sqrt(16)) + (Math.Sqrt((15 % 5) * 5 + 9)) + (Math.Pow(388 / 100, 2) - 1));
        column2 = (int)((Math.Abs(9 - 16)) + (Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2))) + (Math.Abs(-15) - (int)(14.5)));
        column3 = (int)(((int)2.94) + ((int)(7.9) * 7) + (Math.Max(36 / 10 % 2, 6)));

        Console.WriteLine("The sum of Column 1 = {0}", column1);
        Console.WriteLine("The sum of Column 2 = {0}", column2);
        Console.WriteLine("The sum of Column 3 = {0}", column3);

        Console.WriteLine();

        digRtoL = (int)((Math.Sqrt(16)) + (Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2))) + (Math.Max(36 / 10 % 2, 6)));
        digLtoR = (int)(((int)2.94) + (Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2))) + (Math.Pow(388 / 100, 2) - 1));

        Console.WriteLine("The sum of Diagonal from Right to Left is: {0}", digRtoL);
        Console.WriteLine("The sum of Diagonal from Left to Right is: {0}", digLtoR);

        Console.ReadKey();
    }
}