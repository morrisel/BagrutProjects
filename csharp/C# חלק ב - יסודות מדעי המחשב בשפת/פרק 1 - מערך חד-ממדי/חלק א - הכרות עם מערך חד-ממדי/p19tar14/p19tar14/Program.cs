using System;

/* קלט: קליטת מספרים שלמים בגודל המערך הנתוך */
/* פלט: הודע, האם כל המספרים שהוזנו שווים זה לזה שבמערך */
class Program
{
    static void Main()
    {
        bool found = false;
        int num = 0, count = 0;
        int[] a = { 4, 9, 2, 8, 6, 5 };
        //int[] b = { 4, 9, 2, 8, 6, 5 };
        //int[] a = { 3, 3, 3, 3, 3, 3 };

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (a[i] == num)
                found = true;
            else
            {
                found = false;
                count++;
            }
        }

        if (count > 0)
        {
            found = false;
            Console.Write("\n found is: {0}", found);
        }
        else
            Console.Write("\n found is: {0}", found);

        Console.ReadKey();
    }
}