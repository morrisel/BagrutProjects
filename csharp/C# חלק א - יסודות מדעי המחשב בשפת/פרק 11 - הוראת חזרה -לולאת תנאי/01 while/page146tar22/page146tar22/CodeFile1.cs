using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        bool flag = false;
        double r_num;
        int num, count = 0;

        Console.Write("Enter an any real number: ");
        r_num = double.Parse(Console.ReadLine());
        num = (int)r_num;
        while (!flag)
        {
            num = num / 10;
            count++;

            if (num == 0)
                flag = true;
        }
        Console.WriteLine(count);
        Console.ReadKey();
    }
}