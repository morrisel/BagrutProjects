using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int coShir = 0, coLee = 0;
        char ch, shir = 'S', lee = 'L';


        Console.WriteLine("Who started the game?");
        Console.Write("\nIf Shir three times getted the 'e', she started the game if Lee three times getted the 'e' than Lee started the game\n\n");

        Console.WriteLine("If Shir started throw the coin insert 'S'");
        Console.WriteLine("If Lee started throw the conin insert 'L'\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nEnter the name 'S' or 'L': ");
            ch = char.Parse(Console.ReadLine());

            if (ch == shir)
            {
                Console.Write("Enter the 'e' or 'p' for probability of coin ");
                ch = char.Parse(Console.ReadLine());
                if (ch == 'e')
                    coShir++;
                if (coShir >= 3)
                {
                    Console.WriteLine("\n*** Shir getted started ***");
                    break;
                }
            }

            if (ch == lee)
            {
                Console.Write("Enter the 'e' or 'p' for probability of coin ");
                ch = char.Parse(Console.ReadLine());
                if(ch=='e')
                    coLee++;
                if (coLee >= 3)
                {
                    Console.WriteLine("\n*** Lee getted started ***");
                    break;
                }
            }
        }

        Console.ReadKey();
    }
}