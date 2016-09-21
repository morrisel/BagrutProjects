using System;

class CodeFile1
{
    /* פלט: תוצאות כל ההטלות ומספר ההטלות */
    static void Main(string[] args)
    {
        int count = 0, cb1, cb2, totalCnt = 0;
        bool flag = false;

        Random rnd = new Random();

        while (!flag)
        {
            cb1 = rnd.Next(1, 7);
            cb2 = rnd.Next(1, 7);


            if (cb1 == cb2)
                count++;

            if (count == 5)
                flag = true;

            totalCnt++;
            Console.WriteLine(" [{0},{1}] <-> {2}", cb1, cb2, totalCnt);
        }

        Console.ReadKey();
    }
}