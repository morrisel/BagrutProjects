using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int sumMoney = 0, i, rakFriend;

        for (i = 0; i <= 10; i++)
        {
            rakFriend = int.Parse(Console.ReadLine());
            sumMoney = sumMoney + rakFriend;

        }
        Console.WriteLine("The sum of all members is: {0}", sumMoney);
        Console.ReadKey();
    }
}