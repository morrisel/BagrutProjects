using System;

class CodeFile1
{
    public static void Main(string[] args)
    {
        double avg;
        double n1, n2, n3;

        Random rnd = new Random();

        n1 = rnd.NextDouble();
        n2 = rnd.NextDouble();
        n3 = rnd.NextDouble();

        avg = (n1 + n2 + n3) / 3;
        
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine();
        Console.WriteLine(avg);

        // Test in cmd
        double num1, num2, num3, avgNum;
        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());
        num3 = double.Parse(Console.ReadLine());

        avgNum = (num1 + num2 + num3) / 3;
        Console.WriteLine(avgNum);

        Console.ReadKey();
    }
}