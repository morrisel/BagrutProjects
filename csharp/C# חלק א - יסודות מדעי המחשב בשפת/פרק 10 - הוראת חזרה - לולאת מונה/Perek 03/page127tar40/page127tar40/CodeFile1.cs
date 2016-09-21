using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int sumRoy = 0, sumTal = 0, numRoy, numTal;
        int royGova = 0, talGova = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nHow many points Roy was hit in {0} game: ", i);
            numRoy = int.Parse(Console.ReadLine());

            Console.Write("How many points Tal was hit in {0} game: \n", i);
            numTal = int.Parse(Console.ReadLine());

            // מונה של שני השחקנים
            royGova++;
            talGova++;

            // צובר את הנקודות של שני השחקנים
            sumRoy = sumRoy + numRoy;
            sumTal = sumTal + numTal;

        }

        Console.WriteLine();

        if (royGova > talGova)
        {
            Console.WriteLine("Roy has more points than Tal.");
            Console.WriteLine("The number points of Roy is: {0}", royGova);
        }
        else
        {
            Console.WriteLine("Tal has more points than Roy.");
            Console.WriteLine("The number points of Tal is: {0}", talGova);
        }

        if (sumRoy > sumTal)
        {

        }
        else
        {
        }

        Console.ReadKey();
    }
}