using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int yourGuess, compGuess, count = 1;

        Random rnd = new Random();

        compGuess = rnd.Next(1, 101);
        //Console.WriteLine(compGuess);
        Console.WriteLine();

        Console.Write("Enter your guess: ");
        yourGuess = int.Parse(Console.ReadLine());

        if (yourGuess == compGuess)
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Very good, you have got the correct number in {0} trials", count);
            Console.WriteLine("*********************************************************");
            count = -1;
        }
        else
            Console.WriteLine("Too many guesses\n");

        while ((count > 0) && (count <= 20))
        {
            if (yourGuess > compGuess)
                Console.WriteLine("Your guess is too hight");
            else
                Console.WriteLine("Your guess is too low");
            count++;
            Console.WriteLine("\n-------------------------------------\n");
            Console.Write("Enter your guess: ");
            yourGuess = int.Parse(Console.ReadLine());

            if (yourGuess == compGuess)
            {
                Console.WriteLine("\n*********************************************************");
                Console.WriteLine("Very good, you have got the correct number in {0} trials", count);
                Console.WriteLine("*********************************************************");
                break;
            }
            else
                Console.WriteLine("Too many guesses\n");
        }

        Console.ReadKey();
    }
}