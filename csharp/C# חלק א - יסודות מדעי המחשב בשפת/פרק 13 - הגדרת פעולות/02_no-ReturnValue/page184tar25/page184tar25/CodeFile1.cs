using System;

class CodeFile1
{
    /* הפעולה מחפשת את השבר (מספר אחרי הנקודה) ומבודד אותו */
    static double RemainderFind(double findRem)
    {
        double intNum, remNum, remNew;

        intNum = Math.Floor(findRem);

        remNum = findRem - intNum;
        remNum = RemainderRound(remNum);

        remNew = intNum + remNum / 100;

        return remNew;
    }

    /* ומחזירה בחזרה ReminderFind הפעולה מעגלת את המספר(שארית) שקיבלה מפעולה */
    static int RemainderRound(double rem)
    {
        double temp;
        int t, num, round;

        temp = rem * 100;
        t = (int)temp;
        round = t;

        if (t > 10)
        {
            num = t % 10;

            if (t < 5)
                round = t - num;
            else
                round = (t - num) + 10;
        }
        else
        {
            if (t < 5)
                round = 0;
            else
                round = 10;
        }

        return round;
    }

    public static void Main(string[] args)
    {
        double cost, roundCost;

        Console.Write("Enter an any cost: ");
        cost = double.Parse(Console.ReadLine());
        roundCost = RemainderFind(cost);

        Console.WriteLine("The cost was rounded from {0} to {1}", cost, roundCost);

        Console.ReadKey();
    }
}