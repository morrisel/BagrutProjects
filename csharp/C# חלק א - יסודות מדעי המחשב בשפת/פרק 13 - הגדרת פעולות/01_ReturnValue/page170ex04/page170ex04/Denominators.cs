using System;

class Denominators
{
    /* טענת כניסה: הפעולה מקבלת 2 מכנים */
    /* טענת יציאה: את המכנה המשותף הקטן ביותר */
    static int Common(int m1, int m2)
    {
        int min, max, sum;
        if (m1 > m2)
        {
            max = m1;
            min = m2;
        }
        else
        {
            max = m2;
            min = m1;
        }
        sum = max;
        while (sum % min != 0)
        {
            sum = sum + max;
        }
        return sum;
    }



    /* קלט: 4 מכנים */
    /* פלט: המכנה המשותף הקטן ביותר */
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, me1, me2, final;

        Console.WriteLine("Please enter 4 numbers");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        me1 = Common(n1, n2);
        me2 = Common(n3, n4);

        final = Common(me1, me2);

        Console.WriteLine("\n{0} The smallest common denominator", final);



        Console.ReadKey();
    }
}