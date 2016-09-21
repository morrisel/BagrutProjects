using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int countFor = 0, countAgainst = 0, countInavitable = 0, count = 0;
        double p = 1;
        char ch;


        Console.WriteLine("\nThe program gives the results of the referendum on the reform in education");
        Console.WriteLine("\nFor \"For\" please enter a 'y' character");
        Console.WriteLine("For \"Against\" please enter an 'n' character");
        Console.WriteLine("For \"Inavitable\" please enter a 'd' character");
        Console.WriteLine("and for the \"End\" please enter an 'f' character");

        Console.Write("\n\nEnter the result of the referendum: ");
        ch = char.Parse(Console.ReadLine());

        while (ch != 'f')
        {
            switch (ch)
            {
                case 'y': countFor++; break;
                case 'n': countAgainst++; break;
                case 'd': countInavitable++; break;
            }

            count++;

            Console.Write("\nEnter the result of the referendum: ");
            ch = char.Parse(Console.ReadLine());
        }

        p = (countFor * 100) / count;

        if (p >= 60)
            Console.WriteLine("\nThe decision of Ministry of education was adopt the reform");
        else
            Console.WriteLine("\nThe decision of Ministry of education was not adopt the reform");



        Console.ReadKey();
    }
}