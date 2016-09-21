using System;

class Program
{
    const int F = 30;   // מציין מספר הקומות בבניין - F הקבוע
    const int M = 7;    // מציין מספר המשרדים בקומה - M הקבוע

    static void Main()
    {
        int count = 0;
        int[] cabinet = new int[F * M];
        int[] cabinetsInFloor = new int[F];

        //for (int i = 0; i < cabinetsInFloor.Length; i++)
        //    cabinetsInFloor[i] = 0;

        //for (int i = 0; i < cabinet.Length; i++)
        //    cabinet[i] = 0;

        int num;

        for (int i = 0; i < F; i++)
        {
            Console.WriteLine("# " + (i + 1) + " floor ");
            for (int j = 0; j < M; j++)
            {
                // מספר העובדים במשרד
                num = int.Parse(Console.ReadLine());

                cabinet[count] = num;
                count++;

                // עובדים num ית יש-i-של הקומה ה (cabinet) במשרד
                cabinetsInFloor[i] += num;
            }

            // א - סה"כ העובדים בכל קומה
            Console.WriteLine("in floor " + (i + 1) + " there are " + cabinetsInFloor[i] + " - workers");
        }

        Console.WriteLine();

        // ב - מספר הקומה שיש בה הכי פחות עובדים ומספר העובדים בקומה זו
        int min = 0;
        for (int i = 0; i < F; i++)
        {
            if (cabinetsInFloor[i] < cabinetsInFloor[min])
                min = i;
        }
        Console.WriteLine("the floor with minimum workers is: " + (min + 1) + " and workers are: " + cabinetsInFloor[min]);

        Console.WriteLine();

        // ג - מציג את מספר המשרד והקומה של המשרד שיש בו מספר העובדים הכי הרבה
        int max = 0, maxWorkers = 0;
        for (int i = 1; i < F; i++)
            if (cabinetsInFloor[i] > cabinetsInFloor[max])
                max = i;

        //max = max + 1;
        Console.WriteLine("the floor with maximum workers is: " + (max + 1) + " and workers are: " + cabinetsInFloor[max]);

        Console.WriteLine();
        cabinet[0] = maxWorkers;
        for (int i = 1; i < M * F; i++)
        {
            if (cabinet[i] > maxWorkers)
                maxWorkers = cabinet[i];
        }

        Console.WriteLine("the cabinet with max number of workers is: " + maxWorkers + " and the floor is: " + (max + 1));

        Console.ReadKey();
    }
}