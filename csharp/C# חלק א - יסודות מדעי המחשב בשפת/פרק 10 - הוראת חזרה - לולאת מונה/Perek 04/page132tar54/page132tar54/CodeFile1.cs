using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count = 0;
        char tav1, tav2;

        Console.Write("Enter a first character: ");
        tav1 = char.Parse(Console.ReadLine());


        for (int i = 2; i <= 25; i++)
        {
            Console.Write("Enter a character: ");
            tav2 = char.Parse(Console.ReadLine());

            if (tav1 == tav2)
            {
                count++;
            }
        }
        Console.WriteLine("\nThe number of similar on first character is: {0}", count);

        Console.ReadKey();
    }
}