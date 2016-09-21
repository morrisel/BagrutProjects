using System;

class Ch5Solve2LuckyNumber
{
    /* v ומערך שלמים n טענת כניסה: הפעולה מקבלת מערך מחרוזות */
    /* v ואת מספר המזל שלו למערך n טענת יציאה: הפעולה קולטת לכל משתתף את שמו למערך */
    public static void ReadDetails(string[] n, int[] v)
    {
        Console.WriteLine("Enter name and lucky number for each participant");
        for (int i = 0; i < n.Length; i++)
        {
            n[i] = Console.ReadLine();
            v[i] = int.Parse(Console.ReadLine());
        }
    }

    /* ובו מספרי מזל v טענת כניסה: הפעולה מקבלת מערך שלמים */
    /* טענת יציאה: הפעולה מחזירה את מספר המזל השכיח */
    public static int Frequent(int[] v)
    {
        int count;
        int frequentValue = 0;
        int maxFrequency = 0;

        for (int i = 0; i < v.Length; i++)
        {
            count = 1;
            for (int j = i + 1; j < v.Length; j++)
            {
                if (v[i] == v[j])
                {
                    count++;
                }
                if (count > maxFrequency)
                {
                    frequentValue = v[i];
                    maxFrequency = count;
                }
            }
        }

        return frequentValue;
    }

    /* num והערך של מספר מזל ,v מערך מספרי מזל ,n טענת הכניסה: הפעולה מקבלת מערך שמות */
    /* num טענת יציאה: הפעולה מדפיסה את שמות משתתפים להם יש את מספר המזל */
    public static void PrintNames(string[] n, int[] v, int num)
    {
        Console.WriteLine("The most frequent chosen number is: " + num);
        Console.WriteLine("The names of participants that choose it are:");
        for (int i = 0; i < n.Length; i++)
        {
            if (v[i] == num)
                Console.WriteLine(n[i]);
        }
    }


    /* הפעולה הראשית קולטת את השמות ואת מספרי המזל של משתתפי החוג */
    /* ומדפיסה את שלמות המשתתפים שבחרו במספר המזל השכיח */
    static void Main()
    {
        int n;
        string[] names;
        int[] luckNumbers;
        int f;

        Console.WriteLine("Enter number of participants in class:");
        n = int.Parse(Console.ReadLine());

        names = new string[n];
        luckNumbers = new int[n];

        ReadDetails(names, luckNumbers);

        f = Frequent(luckNumbers);

        PrintNames(names, luckNumbers, f);

        Console.ReadKey();
    }
}