using System;

// רצף הספרות הארוך ביותר
class CodeFile1
{
    static void Main(string[] args)
    {
        int num, v1 = 0, v2 = 0;

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        // v1 ספרירת גודל של
        for (int i = num; i != -1; i = num)
        {
            i = num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (i < num)
                v1 = v1 + 1;

            // v2 ספירת גודל של
            for (int j = num; j != -1 && j >= num; j = num)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                if (j >= num)
                    break;

                if (j < num)
                    v2 = v2 + 1;
            }

            // v2-ל v1 השוואה בין
            if (v1 > v2)
                v2 = 0;
            else
                v1 = 0;
        }

        if (v2 >= v1)
            Console.Write("\n\nThe longest sequence of digit is: {0} comes from \"IF\"", v2-1);
        else
            Console.Write("\n\nThe longest sequence of digit is: {0} ", v1);

        Console.ReadKey();
    }
}