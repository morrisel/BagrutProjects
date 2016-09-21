using System;

class CodeFile1
{
    // Even numbers
    static void Main(string[] args)
    {
        int evenNum, evenCount = 0, i;
        Console.WriteLine("Enter an eight integer numbers");
        for (i = 1; i <= 8; i++)
        {
            evenNum = int.Parse(Console.ReadLine());
            if (evenNum % 2 == 0)
                evenCount++;
        }
        Console.WriteLine("The number of even nubers is {0}", evenCount);
        Console.ReadKey();
    }
}