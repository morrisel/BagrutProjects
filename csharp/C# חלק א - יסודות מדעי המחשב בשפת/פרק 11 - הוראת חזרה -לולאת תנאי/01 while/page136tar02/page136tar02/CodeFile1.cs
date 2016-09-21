using System;

class CodeFile1
{
    static void Main(string[] args)
    {

        /*
        int num1 = -4, num2 = 0, count1 = 0;
        while (num1 <= num2)
        {
            num2 = num2 - 2;
            count1++;
        }
        Console.WriteLine("\n\n{0}", count1);
        */

        int a = 24, b = 15, count2 = 0;
        while (a != b)
        {
            b = b + 3;
            count2++;
        }
        Console.WriteLine("\n\n{0}", count2);
        
        /*
        int num = 12, count3 = 0;
        while (num > 10)
        {
            num = num - 2;
            count3++;
        }
        Console.WriteLine("\n\n{0}", count3);
        */

        
        Console.ReadKey();
    }
}