using System;

class Ch2Solve2Army
{
    const int C = 3, M = 4;

    static int Mahlaka(int[,] p, int i)
    {
        int sum = 0;

        for (int j = 0; j < M; j++)
            sum += p[i, j];

        return sum;
    }

    /* p מקבל את ערך הפלוגה Max טענת כניסה: הפעולה */
    /* טענת יציאה: הפעולה מחזירה את האיבר המקסימלי */
    static int Max(int[,] p)
    {
        int big = 0;

        for (int i = 0; i < C; i++)
            for (int j = 0; j < M; j++)
                if (p[i, j] > big)
                    big = p[i, j];

        return big;
    }

    /* p מקבלת את מערך הפלוגה PrintPluga טענת הכניסה: הפעולה */
    /* טענת יציאה: הפעולה מדפיסה את מספר החיילים בכל מחלקה ואת מספר החיילים בכל הפלוגה */
    static void PrintPluga(int[,] p)
    {
        int num, sum = 0;

        for (int i = 0; i < C; i++)
        {
            num = Mahlaka(p, i);

            Console.WriteLine("There are " + num + " soldiers in mahlaka " + (i + 1));
        }

        Console.WriteLine("There are " + sum + " soldiers in the pluga");
    }


    static void Main()
    {
        int[,] p = new int[C, M];
        //int[,] p = new int[,] { { 50, 55, 60 }, { 38, 60, 45 }, { 37, 40, 57 }, { 60, 44, 55 } };
        // מספר החיילים המקסימלי בכיתה
        int maxi;

        for (int i = 0; i < C; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("Enter the number of soldiers in mahlaka " + (i + 1) + " kitah " + (j + 1) + " ");
                p[i, j] = int.Parse(Console.ReadLine());
            }
        }

        PrintPluga(p);
        
        maxi = Max(p);
        Console.WriteLine("The max number of soldiers in kitah " + maxi);
        for (int i = 0; i < C; i++)
            for (int j = 0; j < M; j++)
                if (p[i, j] == maxi)
                    Console.WriteLine("Mahlaka " + i + " kitah " + j);

        Console.ReadKey();
    }
}