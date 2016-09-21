using System;

class Randomize
{
    /* טענת כניסה: הפעולה מקבלת שני מספרים שלמים */
    /* טענת יציאה: הפעולה מדפיסה עבור כל זוג סדור 5 מספרים אקראיים בטווח ערכי הזוג */
    static int RandomNumbers(int a, int b)
    {
        int num = 0;

        Random rnd = new Random();

        while (a != -999 && b != -999)
        {
            Console.WriteLine();
            Console.Write("The function \"RandomNumbers\" create: - - - >  ");
            for (int i = 0; i < 5; i++)
            {
                num = rnd.Next(a, b);
                Console.Write(" {0} ", num);
            }

            Console.WriteLine("\n\nFor stop the program enter -999 for first and -999 for second number");
            Console.Write("Enter a first number of pair: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter a follow number of pair: ");
            b = int.Parse(Console.ReadLine());
        }

        return num;
    }


    /* קלט: שני מספרים שלמים */
    /* פלט: הפעולה מחזירה ערכים אקריים מודפסים */
    public static void Main(string[] args)
    {
        int n1, n2, test;

        Console.Write("Enter a first number of pair: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a follow number of pair: ");
        n2 = int.Parse(Console.ReadLine());
        test = RandomNumbers(n1, n2);
        Console.WriteLine(test);
        Console.WriteLine("The test is beginning...");
        Console.WriteLine(RandomNumbers(n1, n2));
        Console.WriteLine("Gooood byeee.......!");

        Console.ReadKey();
    }
}