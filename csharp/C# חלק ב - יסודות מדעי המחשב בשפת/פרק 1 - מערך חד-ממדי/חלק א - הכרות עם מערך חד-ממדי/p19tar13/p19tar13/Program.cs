using System;

/* נמצא במערך num האלגוריתם הבא בודק האם הערך במשתנה */
class CodeFile1
{
    static void Main()
    {
        bool found = false;
        int num;
        int[] a = { 4, 9, 2, 8, 6, 5 };

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == num)
            {
                found = true;
                break;
            }
            else
                found = false;
        }
        Console.Write("\nThe number that putted is: {0} - it's {1}", num, found);

        Console.ReadKey();
    }
}