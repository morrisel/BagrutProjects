using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int count = 1, sum = 0, num, min, dif = 100, x = 0, y = 0, mid = 0;
        int n;
        double avg = 0.0;

        Console.Write("please enter an odd number for loop counter: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter a first number of pair: ");
        num = int.Parse(Console.ReadLine());
        min = num;
        sum = sum + num;

        for (int i = 1; i < n; i++)
        {
            int temp;

            Console.Write("Enter a follow number of pair: ");
            num = int.Parse(Console.ReadLine());

            temp = num - min;
            if (dif > temp)             // יקבלו אותם y-ו x בודק האם זוג המספרים שההפרש שלהם קטן ביותר, אם כן - אז הערכים
            {
                dif = temp;
                x = min;
                y = num;
            }

            if (count == n / 2)
                mid = num;

            min = num;
            sum = sum + num;
            count = count + 1;
        }

        avg = (double)sum / count;
        Console.WriteLine("\ntest...\naverage = {0}", avg);
        Console.WriteLine("the pair that difference is small ({0},{1})", x, y);
        Console.WriteLine("middle element = {0}", mid);

        Console.ReadKey();
    }
}