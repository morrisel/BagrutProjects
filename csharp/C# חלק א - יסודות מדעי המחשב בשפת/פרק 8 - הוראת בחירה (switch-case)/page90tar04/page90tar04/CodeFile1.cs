using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        float num1, num2;
        //char plus = '+', minus, power, division;
        char tav;

        Console.Write("Enter a first number ");
        num1 = float.Parse(Console.ReadLine());

        Console.Write("\nEnter \"+\", \"-\", \"*\" or \"/\" character ");
        tav = char.Parse(Console.ReadLine());

        Console.Write("\nEnter a second number ");
        num2 = float.Parse(Console.ReadLine());

        switch (tav)
        {
            case '+': Console.Write(num1 + num2); break;
            case '-': Console.Write(num1 - num2); break;
            case '*': Console.Write(num1 * num2); break;
            case '/': Console.Write(num1/num2); break;

        }
        

        Console.ReadKey();
    }
}