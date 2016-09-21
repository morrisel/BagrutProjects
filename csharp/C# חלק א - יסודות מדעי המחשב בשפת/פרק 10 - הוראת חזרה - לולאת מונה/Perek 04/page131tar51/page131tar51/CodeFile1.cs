using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double pos, neg, num;

        Console.WriteLine("The program is printing two numbers");
        Console.WriteLine("The minimal positive and maximal negative numbers.\n");
        

        Console.Write("Enter an integer number: ");
        num = double.Parse(Console.ReadLine());

        pos = num;
        neg = num;

        for (int i = 2; i <= 10; i++)
        {
            Console.Write("Enter an integer number: ");
            num = double.Parse(Console.ReadLine());

            if (num < 0)
            {
                if (neg > 0)
                    neg = num;

                if (num > neg)
                    neg = num;
            }
            else
            {
                if (neg > 0)
                    neg = num;
                /*
                if (num > neg && num < 0)
                    neg = num;
                */
                if (pos < 0)
                    pos = num;

                if (num < pos && num > 0)
                    pos = num;
            }
        }
        Console.WriteLine("\n\nmin positive = {0}", pos);
        Console.WriteLine("max negative = {0}", neg);

        
        Console.ReadKey();
    }
}