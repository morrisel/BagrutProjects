using System;

class CodeFile1
{
    /* טענת כניסה: מספר שלם */
    /* טענת יציאה: מחזירה את הערך הבוליאני */
    static bool IsPrime(int num)
    {
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                return false;
        return true;
    }

    /* קלט: מספר שלם כלשהו */
    /* פלט: הודעה מתאימה עבור המספר שהוזן */
    static void Main(string[] args)
    {
        int num = 0;
        bool found = true;

        Console.Write("Please enter a positive number: ");
        num = int.Parse(Console.ReadLine());

        found = IsPrime(num);

        if (found)
            Console.WriteLine("\n {0} it is a prime number", num);
        else
            Console.WriteLine("\n {0} it isn't a prime number", num);
        
        

        Console.ReadKey();
    }
}

