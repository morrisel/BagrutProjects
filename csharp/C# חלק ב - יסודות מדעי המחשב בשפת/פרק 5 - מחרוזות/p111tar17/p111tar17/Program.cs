using System;

class Program
{
    static int Guess(string st)
    {
        int init = 0;
        int count = 0;

        for (char i = 'a'; i <= 'z'; i++)
        {
            init = st.IndexOf(i);
            if (init != -1)
                count++;
        }

        return count;
    }

    static void Main()
    {
        // א
        int num;
        string str;

        Console.WriteLine("Enter a some string:");
        str = Console.ReadLine();

        num = Guess(str);
        Console.WriteLine("The number is {0}", num);

        // ב
        Console.WriteLine("\nEnter a some string:");
        str = Console.ReadLine();

        num = Guess(str);
        Console.WriteLine("The number is {0}", num);

        // ג
        // abc-מטרת הפעולה, היא למצוא מהו מספר האותיות השונות של המחרוזת המופיעות מה

        // ד
        // abc-טווח הערכים הוא בין 0 ל-26, כלומר מספר האותיות מה



        Console.ReadKey();
    }
}