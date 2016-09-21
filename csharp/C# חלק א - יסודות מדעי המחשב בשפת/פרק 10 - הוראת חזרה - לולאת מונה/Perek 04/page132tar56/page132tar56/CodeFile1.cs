using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num, hundreds, tens, units, count = 0;



        for (int i = 2; i <= 8; i++)
        {
            Console.Write("Enter a three-digit number: ");
            num = int.Parse(Console.ReadLine());

            hundreds = num / 100;
            tens = (num % 100) / 10;
            units = (num % 100) % 10;

            //Console.WriteLine("{0}, {1}, {2}", hundreds, tens, units);

            if (hundreds==tens||hundreds==units||tens==units|| (hundreds==units&&hundreds==tens))
            {
                Console.WriteLine("\nThe number is: {0}", num);
                count++;
            }
        }

        Console.WriteLine("\nThe number of similar numbers is: {0}", count);
        Console.ReadKey();
    }
}