using System;

class CodeFile1
{
    // The program solve with operator the mathematical basic promblems
    // Input: number, operator, number
    // Output: the program print the solution
    static void Main(string[] args)
    {
        char ch;
        double n1, n2;

        Console.Write("Enter a number:\t\t");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Enter an operator:\t");
        ch = char.Parse(Console.ReadLine());
        Console.Write("Enter a number:\t\t");
        n2 = double.Parse(Console.ReadLine());

        switch (ch)
        {
            case '+': Console.WriteLine("{0} {1} {2} = {3}", n1, ch, n2, n1 + n2); break;
            case '-': Console.WriteLine("{0} {1} {2} = {3}", n1, ch, n2, n1 - n2); break;
            case '*': Console.WriteLine("{0} {1} {2} = {3}", n1, ch, n2, n1 * n2); break;
            case '/': Console.WriteLine("{0} {1} {2} = {3}", n1, ch, n2, n1 / n2); break;
        }

        Console.ReadKey();
    }
}