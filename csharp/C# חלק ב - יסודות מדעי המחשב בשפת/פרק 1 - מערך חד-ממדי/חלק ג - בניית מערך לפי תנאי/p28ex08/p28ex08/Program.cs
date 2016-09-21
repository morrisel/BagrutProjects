using System;

class Program
{
    const int N = 8;

    static void Main()
    {
        int j = 1, num;
        int[] numbers = new int[N];

        Console.Write("Enter a number: ");
        numbers[0] = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num != numbers[j - 1])
            {
                numbers[j] = num;
                j++;
            }
        }

        for (int i = 0; i < j; i++)
        {
            Console.Write(" " + numbers[i]);
        }


        Console.ReadKey();
    }
}