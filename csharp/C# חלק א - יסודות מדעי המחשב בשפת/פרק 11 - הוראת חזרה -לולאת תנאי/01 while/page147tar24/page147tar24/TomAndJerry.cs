using System;

class TomAndJerry
{
    static void Main(string[] args)
    {
        bool flg = false;
        int tom, jerry, nxTom = 10, nxJerry = 40, count = 0;
        char ch;

        Random rnd = new Random();

        Console.WriteLine("\n\nThis is a little story about TOM and JERRY\n");

        while (!flg)
        {
            // TOM's movie
            tom = rnd.Next(-5, 6);
            Console.WriteLine("TOM move from {0} to {1}", nxTom, nxTom + tom);
            nxTom = nxTom + tom;

            if (nxTom == nxJerry || nxJerry < 1 || nxJerry > 50)
            {
                Console.WriteLine("\n * * *   TOM Victory JERRY   * * * \n");
                flg = true;
            }

            // JERRY's movie
            jerry = rnd.Next(-5, 6);
            Console.WriteLine("JERRY move from {0} to {1}", nxJerry, nxJerry + jerry);
            nxJerry = nxJerry + jerry;

            if (nxJerry == nxTom || nxTom < 1 || nxTom > 50)
            {
                Console.WriteLine("\n * * *   JERRY Victory TOM   * * * \n");
                flg = true;
            }

            count++;

            Console.WriteLine();
            Console.WriteLine("Do you want to continue play? Press 'y' or 'n'");
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'y':
                    if (flg) { flg = true; }
                    else { flg = false; }
                    break;
                case 'n': flg = true; break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("\nThank You!!!");

        Console.ReadKey();
    }
}