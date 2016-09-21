using System;


class CodeFile1
{
    static void Main(string[] args)
    {
        int cAge1 = 0, cAge2 = 0, group, trainer1, trainer2;

        Console.WriteLine();

        for (int i = 1; i <= 30; i++)
        {
            Console.Write("Enter the ages of children between 8-11 of 12-15: ");
            group = int.Parse(Console.ReadLine());

            if (group <= 11 && group >= 8)
            {
                cAge1++;
            }
            else
            {
                if (group <= 15 && group >= 12)
                {
                    cAge2++;
                }
                else
                    continue;
            }


        }
        Console.WriteLine("\n\n");

        trainer1 = cAge1 / 4;
        trainer2 = cAge2 / 7;

        Console.WriteLine("Group-1 children = {0}, trainers = {1}", cAge1, trainer1);
        Console.WriteLine("\nGroup-2 children = {0}, trainers = {1}", cAge2, trainer2);

        Console.ReadKey();
    }
}