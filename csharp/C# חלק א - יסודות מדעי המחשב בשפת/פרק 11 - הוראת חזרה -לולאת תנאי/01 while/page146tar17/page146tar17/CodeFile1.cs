using System;

class CodeFile1
{
    /* פלט: האלגוריתם מציג את המספר השלם הקטן ביותר עבורו הסכום הוא לפחות 500 */
    static void Main(string[] args)
    {
        int num = 1, sum = 0, sq = 1;
        bool flag = false;

        while (!flag)
        {
            Console.WriteLine(num);

            sq = num * num;
            sum = sum + sq;
            num = num + 1;
            
            if (sum >= 500)
                flag = true;
        }

        Console.WriteLine(num - 1);

        Console.ReadKey();
    }
}