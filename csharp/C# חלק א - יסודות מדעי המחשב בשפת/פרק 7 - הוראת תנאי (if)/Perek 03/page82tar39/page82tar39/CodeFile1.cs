using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int psycho;
        float bagrut;
        float avg;

        Console.Write("Enter your grade of Psychometric test: ");
        psycho = int.Parse(Console.ReadLine());

        Console.Write("Enter your average of Bagrut: ");
        bagrut = float.Parse(Console.ReadLine());




        // Study in University
        if (psycho >= 600 && bagrut >= 90)
        {
            Console.WriteLine("You are accepting to study in University");
        }
        else
        {
            if (psycho >= 600 && bagrut < 90)
            {
                Console.WriteLine("You must to improve your grade of Bagrut");
            }
            else
            {
                if (psycho < 600 && bagrut >= 90)
                {
                    Console.WriteLine("You must to improve your grade of Psychometric test");
                }
                else
                {
                    Console.WriteLine("You must to go to renew these tests");
                    if (psycho < 600 && bagrut < 90)
                        Console.WriteLine("\nYou are unable to accept in University");
                }
            }
        }

        Console.ReadKey();
    }
}