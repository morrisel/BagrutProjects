using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num;
        double avg = 3;

        Random rnd = new Random();

        num = rnd.Next(1, 7);
        Console.WriteLine("Random number \t\t{0}", num);
        Console.WriteLine("Quadratic number \t{0}", num * num);
        num = (int)Math.Abs(num - avg);
        Console.WriteLine("Abolut length \t\t{0}", num);

        Console.ReadKey();
    }
}