using System;

class CodeFile1
{
    static void Main(string[] args)
    {

        for (int player = 1; player <= 20; player++)
        {
            int gamePlayer = 1231, goal, sum;
            int first, second, third;
            double avg;


            first = gamePlayer / 1000;
            Console.Write("Enter the numbers' goals of Player {0} in the first game ", player);
            goal = int.Parse(Console.ReadLine());
            first = goal;
            Console.Write("{0} goals in first game\n", first);

            second = (gamePlayer / 100) % 10;
            Console.Write("\nEnter the numbers' goals of Player {0} in the second game ", player);
            goal = int.Parse(Console.ReadLine());
            second = goal;
            Console.Write("{0} goals of the {1} game\n", second, player);

            third = (gamePlayer % 100) / 10;
            Console.Write("\nEnter the numbers' goals of Player {0} in the third game ", player);
            goal = int.Parse(Console.ReadLine());
            third = goal;
            Console.Write("{0} goals of the {1} game\n", third, player);


            avg = (double)(first + second + third) / 3;
            sum = first + second + third;

            Console.WriteLine("\nThe average of player {0} is: {1}\n", player, avg);
            if (sum == 0)
            {
                Console.WriteLine("The player {0} doesn't score goal", player);
            }
            else
            {
                if (sum >= 5)
                {
                    Console.WriteLine("The player {0} is exellent player", player);
                }
            }

            Console.WriteLine("\n-----------------------------------------------\n");
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}