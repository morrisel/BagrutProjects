using System;

class Program
{
    static void Main()
    {
        int[] action = { 2, 31, 11, 1, -40, 10 };
        int[] result = new int[action.Length / 3];

        int i = 0;
        while (i < result.Length)
        {
            for (int j = 0; j < action.Length; j += 3)
            {
                if (action[j] == 1)
                {
                    result[i] = action[j + 1] + action[j + 2];
                }
                else
                {
                    if (action[j] == 2)
                    {
                        result[i] = action[j + 1] - action[j + 2];
                    }
                }
                i++;
            }
        }

        for (i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        Console.ReadKey();
    }
}

// פיתרון נוסף - הכללה
/*
class Program
{
    static void Main(string[] args)
    {
        bool flag = false;
        int n = 0;
        int[] action, result;

        while (!flag)
        {
            Console.Write("Enter a number for length of array: ");
            n = int.Parse(Console.ReadLine());
            if (n % 3 == 0 && n >= 3)
                flag = true;
        }

        // action יצירת מערך
        action = new int[n];
        for (int i = 0; i < action.Length; i++)
            Console.Write("action[{0}] = {1}\n", i, action[i]);
        Console.WriteLine();

        // מקבל מספרים שלמים action המערך
        for (int i = 0; i < action.Length; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write("Enter number 1 or 2: ");
                action[i] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Enter an any number: ");
                action[i] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        // action הצגת מערך
        for (int i = 0; i < action.Length; i++)
            Console.Write("action[{0}] = {1}\n", i, action[i]);

        Console.WriteLine();

        // result יצירת מערך
        result = new int[n / 3];

        // result למערך action מתבצעת העתקת ערכים מחושבים ממערך
        for (int j = 0; j < result.Length; )
        {
            for (int i = 0; i < action.Length; i++)
            {
                if (i % 3 == 0)
                {
                    if (action[i] == 1)
                        result[j] = action[i + 1] + action[i + 2];

                    if (action[i] == 2)
                        result[j] = action[i + 1] - action[i + 2];
                    j++;
                }
            }
        }

        for (int j = 0; j < result.Length; j++)
            Console.Write("\nresult[{0}] = {1}", j, result[j]);
        Console.WriteLine();

        Console.ReadKey();
    }
}
*/