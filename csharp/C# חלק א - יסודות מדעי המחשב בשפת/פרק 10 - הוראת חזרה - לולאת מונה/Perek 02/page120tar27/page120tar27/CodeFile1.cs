using System;

// Handed in a paper
class CodeFile1
{
    static void Main(string[] args)
    {
        int i, twoWork = 0, oneWork = 0, notWork = 0;
        double grade1, grade2;

        Console.WriteLine("Enter grades for two students");

        for (i = 1; i <= 20; i++)
        {
            Console.WriteLine();
            grade1 = double.Parse(Console.ReadLine());
            grade2 = double.Parse(Console.ReadLine());
            if (grade1 > 0 && grade2 > 0)
                twoWork++;
            else
            {
                if (grade1 < 0 && grade2 < 0)
                    notWork++;
                else
                    oneWork++;
            }
        }
        Console.WriteLine("The {0} students handed in a \"Two\" paper work", twoWork);
        Console.WriteLine("The {0} students handed in a \"One\" paper work", oneWork);

        if (notWork > 0)
            Console.WriteLine("The {0} students have \"-1\" handed in a work", notWork);
        
        Console.ReadKey();
    }
}