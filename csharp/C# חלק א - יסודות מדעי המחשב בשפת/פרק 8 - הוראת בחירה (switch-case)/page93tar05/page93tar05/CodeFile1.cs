using System;

// התוכנה מחשבת משכורת של עובד על-פי הגדרת תפקידו
class CodeFile1
{
    /* קלט: דרגת של עובד, מספר השעות שעבד בחודש */
    /* פלט: משכורת של עובד */
    static void Main(string[] args)
    {
        char ch;
        double nh;
        
        Console.WriteLine("\nThe table is describe the posts of employers");
        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("\tDirector - 'd'");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("\tAlgorithmist - 'a' \tProgrammer - 'p'");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("\tOthers - 'o'");
        Console.WriteLine("-----------------------------------------------------\n");
        
        Console.Write("Enter a character for post of employer\t");
        ch = char.Parse(Console.ReadLine());
        Console.Write("Enter an amount of working hours\t");
        nh = double.Parse(Console.ReadLine());

        switch (ch)
        {
            case 'd': Console.WriteLine("The salary of worker {0} is {1}", ch, nh * 100); break;
            case 'a': Console.WriteLine("The salary of worker {0} is {1}", ch, nh * 80); break;
            case 'p': Console.WriteLine("The salary of worker {0} is {1}", ch, nh * 50); break;
            case 'o': Console.WriteLine("The salary of worker {0} is {1}", ch, nh * 20); break;
        }

        Console.ReadKey();
    }
}