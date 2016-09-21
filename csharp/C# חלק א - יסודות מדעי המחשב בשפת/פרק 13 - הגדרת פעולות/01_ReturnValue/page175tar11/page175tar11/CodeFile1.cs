using System;

// תווים
class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת תו */
    /* false או true טענת יציאה: הפעולה מחזירה */
    static bool FindLetter(char tav)
    {
        bool letBool = false;

        if ((tav >= 'A' && tav <= 'Z') || (tav >= 'a' && tav <= 'z'))
            letBool = true;
        else
            letBool = false;

        return letBool;
    }


    /* קלט: 20 סדרות של תווים */
    /* פלט: כל סדרה בשורה חדשה ואת אורך הסדרה הקטנה ביותר */
    public static void Main(string[] args)
    {
        int min = 0, count = 0;
        char ch = 'a';
        bool found = false;

        Console.Write("Enter the characters\n\n");
        for (int i = 1; i <= 20; i++)
        {
            while (!found)
            {
                ch = char.Parse(Console.ReadLine());
                found = FindLetter(ch);

                if (found == true)
                {
                    count++;
                    found = false;
                }
                else
                    found = true;
            }

            Console.WriteLine("\nThe number of letters is {0}", count);

            min = count;

            if (count < min)
                min = count;
        }
        Console.WriteLine("\nThe mininmum number of letters is {0}", min);

        Console.ReadKey();
    }
}