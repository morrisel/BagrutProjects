using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        char ans;
        int countY = 0, countN = 0;
        Console.WriteLine("Enter the jury member vote");
        for (int i = 1; i <= 12; i++)
        {
            ans = char.Parse(Console.ReadLine());
            if (ans == 'y')
                countY++;
            else
                countN++;
        }
        if (countN > countY)
            Console.WriteLine("Innocent");
        else
        {
            if (countY > countN)
                Console.WriteLine("Guilty");
            else
                Console.WriteLine("No decision");
        }


        Console.ReadKey();
    }
}