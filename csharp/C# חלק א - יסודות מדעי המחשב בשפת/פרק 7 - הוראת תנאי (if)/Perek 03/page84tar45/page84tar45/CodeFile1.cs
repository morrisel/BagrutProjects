using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num1, num2, num3;
        char ch1, ch2, ch3;
        char y = 'Y', n = 'N';
        bool check1, check2, check3;

        Console.WriteLine("The Puzzle Game\n");
        Console.WriteLine("Puzzle game has box 3x3");
        Console.WriteLine("Enter three number 1 - 9\n");

        Console.Write("What the number can will be in row1? ");
        num1 = int.Parse(Console.ReadLine());
        check1 = (1 <= num1) && (num1 <= 3);
        Console.WriteLine(check1);

        Console.Write("What the number can will be in row2? ");
        num2 = int.Parse(Console.ReadLine());
        check2 = (4 <= num2) && (num2 <= 6);
        Console.WriteLine(check2);

        Console.Write("What the number can will be in row3? ");
        num3 = int.Parse(Console.ReadLine());
        check3 = (7 <= num3) && (num3 <= 9);
        Console.WriteLine(check3);


        if (check1 && check2 && check3)
        {
            Console.WriteLine("\nAre you on row 1 ?");
            Console.Write("\nEnter \"Y\" or \"N\" key for right or wrong of rows what you will put ");
            ch1 = char.Parse(Console.ReadLine());
            if (ch1 == y)
                Console.WriteLine(y + " <=> " + check1);
            else
                Console.WriteLine(n + " <=> " + !check1);


            Console.WriteLine("\nAre you on row 2 ?");
            Console.Write("\nEnter \"Y\" or \"N\" key for right or wrong of rows what you will put ");
            ch2 = char.Parse(Console.ReadLine());
            if (ch2 == y)
                Console.WriteLine(y + " <=> " + check2);
            else
                Console.WriteLine(n + " <=> " + !check2);


            Console.WriteLine("\nAre you on row 3 ?");
            Console.Write("\nEnter \"Y\" or \"N\" key for right or wrong of rows what you will put ");
            ch3 = char.Parse(Console.ReadLine());
            if (ch3 == y)
                Console.WriteLine(y + " <=> " + check3);
            else
                Console.WriteLine(n + " <=> " + !check3);

            if (check1 && check2 && check3)
            {
                Console.WriteLine("You   Are   W i n   !");
            }
            else
                Console.WriteLine("You are Loss");

        }
        else
        {
            Console.WriteLine("\n\n\t\tYou are Loss");
        }
            

        
        

        Console.ReadKey();
    }
}