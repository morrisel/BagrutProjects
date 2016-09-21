using System;

class CodeFile1
{
    /* טענת כניסה: הפעולה מקבלת מספר */
    /* טענת היציאה: הפעולה מחזירה את מספר ספרותיו הזוגיות */
    static int MaxSearch(int n)
    {
        int count = 0;
        for (int i = n % 10; i != 0; i = n % 10)
        {
            if (i % 2 == 0)
                count++;
            n = n / 10;
        }
        return count;
    }

    /* מספרים שלמים n :קלט */
    /* פלט: מספר שמכיל את המספר הגדול ביותר של ספרות זוגיות */
    public static void Main(string[] args)
    {
        int num, count1, count2, maxNum1, maxNum2;

        Console.Write("Enter an integer number: ");
        num = int.Parse(Console.ReadLine());
        maxNum1 = num;
        count1 = MaxSearch(maxNum1);
        
        for (int i = 2; i != -1; i++)
        {
            Console.Write("Enter an integer number: ");
            num = int.Parse(Console.ReadLine());
            maxNum2 = num;
            count2 = MaxSearch(maxNum2);

            if (count1 > count2)
                Console.WriteLine("The number that even digit of number is longest is: {0}", maxNum1);
            else
                Console.WriteLine("The number that even digit of number is longest is: {0}", maxNum2);

            if (num == -1)
                break;
        }
        
        Console.ReadKey();
    }
}