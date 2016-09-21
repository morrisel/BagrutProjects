using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int num;

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("putted number is: {0}", num);

        for (int i = 1; i <= 30; i++)
        {
            int number;

            Random randNum = new Random();

            number = randNum.Next(10, 20);
            Console.WriteLine();

            if (((num + 4) >= number) && ((num - 4) <= number))
            {
                Console.Write(" {0} & {1} Matching", num, number);
            }
            else
            {
                Console.Write(" {0} & {1} Isn't matching", num, number);
            }
            
        }

        Console.ReadKey();
    }
}