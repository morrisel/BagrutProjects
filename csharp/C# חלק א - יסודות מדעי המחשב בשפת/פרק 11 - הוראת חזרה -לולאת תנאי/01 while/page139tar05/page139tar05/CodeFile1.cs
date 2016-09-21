using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int heightCount = 0;
        double height;

        Console.WriteLine("To stop the program, press (zero)");
        height = double.Parse(Console.ReadLine());
        while (height != 0)
        {
            if (height > 1.60)
                heightCount++;
            height = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The number students of height more over 1.60 is: {0}", heightCount);


        Console.ReadKey();
    }
}