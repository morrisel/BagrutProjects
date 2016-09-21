using System;

class CodeFile1
{
    // The specific temperature
    static void Main(string[] args)
    {
        int count = 0, day;
        double tem;
        Console.WriteLine("The program presents a specific temperature");
        Console.WriteLine("Enter a number of temperature");
        for (day = 1; day <= 7; day++)
        {
            tem = double.Parse(Console.ReadLine());
            if (tem > 16)
                count++;
        }
        Console.WriteLine("The days what temperature is over 16 degree is {0} days", count);

        Console.ReadKey();
    }
}