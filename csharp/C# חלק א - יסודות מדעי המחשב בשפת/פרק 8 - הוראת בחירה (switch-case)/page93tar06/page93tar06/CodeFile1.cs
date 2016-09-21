using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("Enter a value 0, 15, 30, 40 or 60 of Player");

        Console.Write("Enter a value of first Player ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a value of second Player ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (num1)
        {
            case 0:
                switch (num2)
                {
                    case 0:
                    case 15:
                    case 30:
                    case 40:
                    case 60:
                        Console.Write("First {0}\tSecond {1}\n", num1, num2);
                        if (num1 > num2)
                            Console.WriteLine("Difference of numbers is: {0}", num1 - num2);
                        else
                            Console.WriteLine("Difference of numbers is: {0}", num2 - num1);
                        break;
                }
                break;
            case 15:
            case 30:
            case 40:
            case 60:
                Console.Write("First {0}\tSecond {1}\n", num1, num2);
                if (num1 > num2)
                    Console.WriteLine("Difference of numbers is: {0}", num1 - num2);
                else
                    Console.WriteLine("Difference of numbers is: {0}", num2 - num1);
                break;
        }


        Console.ReadKey();
    }
}