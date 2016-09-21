using System;

// מבחן תיאוריה
class CodeFile1
{
    static void Main(string[] args)
    {
        int passTest = 0, n = 1, errTrafic, errCommon;
        Console.WriteLine("For stop the program enter -1\n");
        Console.WriteLine("\n\n\n");

        for (; n > 0; n++)
        {
            Console.Write("Enter a numbers of participant: ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0)
                continue;
            Console.Write("Enter a lithg traffic errors: ");
            errTrafic = int.Parse(Console.ReadLine());

            Console.Write("Enter a common erros: ");
            errCommon = int.Parse(Console.ReadLine());

            if (errTrafic <= 0 && errCommon <= 3)
            {
                passTest++;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Number of passed test is: {0}", passTest);
        Console.WriteLine("Percentage of passed test is: {0}", (double)passTest / 100);

        Console.ReadKey();
    }
}