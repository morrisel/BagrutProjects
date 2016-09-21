using System;

// אורך הרצף הארוך ביותר
class CodeFile1
{
    static void Main(string[] args)
    {
        int num, max, vec = 1, vecMax = 0;

        Console.WriteLine("\nThe program is checking the longest sequence of numbers and present a very big rasing data\n");
        Console.Write("Enter an any integer number: ");
        num = int.Parse(Console.ReadLine());
        max = num;
        do
        {
            Console.Write("Enter an any integer number: ");
            num = int.Parse(Console.ReadLine());

            //The algorithm compare and arranges the big vector and move to the first place / cell
            if (num > max)
            {
                max = num;
                vec++;
            }
            else
            {
                max = num;
                if (vec >= vecMax)
                    vec = 0;
                vec++;
            }
            if (vecMax < vec)
                vecMax = vec;
        }
        while (num != 0);
        Console.WriteLine("This is a big length: {0}", vecMax);
        Console.ReadKey();
    }
}