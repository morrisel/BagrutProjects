using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        double num, myNum;

        Random rndNum = new Random();

        num = rndNum.Next(41);
        Console.WriteLine(num);

        myNum = num;

        num = Math.Pow(num, 2);
        Console.WriteLine(num);

        myNum = Math.Sqrt(myNum);
        Console.WriteLine(myNum);

        Console.ReadKey();
    }
}