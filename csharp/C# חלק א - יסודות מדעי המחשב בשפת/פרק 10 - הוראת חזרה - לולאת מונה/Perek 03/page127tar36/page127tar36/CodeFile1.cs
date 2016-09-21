using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int evenNum = 0, oddNum = 0, diffNum, i, n, num;

        Console.Write("Enter an N number: ");
        n=int.Parse(Console.ReadLine());

        for (i = 0; i <= n; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)         // even numbers
                evenNum = evenNum + num;
            else                    // odd numbers
            {
                if (num % 2 != 0)
                    oddNum = oddNum + num;
                else
                    continue;
            }
        }

        diffNum = Math.Abs(evenNum - oddNum);

        Console.WriteLine("The sum of even numbers is: {0}", evenNum);
        Console.WriteLine("The sum of odd numbers is: {0}", oddNum);
        Console.WriteLine("The difference of sums is: {0}", diffNum);

        Console.ReadKey();
    }
}