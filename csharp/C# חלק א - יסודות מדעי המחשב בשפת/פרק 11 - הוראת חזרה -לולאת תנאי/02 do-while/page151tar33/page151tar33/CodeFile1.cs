using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double n1, n2 = 0;

        Console.WriteLine("For stop the program press 0");
        Console.Write("Enter a number: ");
        n2 = double.Parse(Console.ReadLine());

        do
        {
            n1 = n2;
            Console.Write("\nEnter a number: ");
            n2 = double.Parse(Console.ReadLine());
            if (n2 == 0)
                break;
            if (n1 > n2)
                Console.WriteLine("({0},{1})", n1, n2);
        }
        while (n2 != 0);

        Console.ReadKey();
    }
}