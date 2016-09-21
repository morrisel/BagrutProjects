using System;

class Program
{
    const int N = 10;

    static void Main()
    {
        int[] heart = new int[N];
        int countA = 1, countB = 1;

        //for (int i = 0; i < N; i++)
        //{
        //    Console.Write("Enter pulse of heart ");
        //    heart[i] = int.Parse(Console.ReadLine());
        //}

        heart = new int[] { 150, 120, 88, 113, 155, 152, 153, 77, 75, 80 };

        for (int i = 1; i < N; i++)
        {
            if (heart[i - 1] > 150 && heart[i] > 150)
            {
                countA++;
                if (countA == 3)
                {
                    Console.WriteLine("The pulse of heart it hight");
                    break;
                }
                countB = 1;
            }

            if (heart[i - 1] < 80 && heart[i] < 80)
            {
                countB++;
                if (countB == 3)
                {
                    Console.WriteLine("The pulse of heart it Low");
                    break;
                }
                countA = 1;
            }
        }

        Console.ReadKey();
    }
}