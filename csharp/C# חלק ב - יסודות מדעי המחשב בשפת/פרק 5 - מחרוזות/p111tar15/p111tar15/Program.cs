using System;

class Program
{
    static string AlefBet()
    {
        int c1 = 0;
        string alefbet = "";

        for (int i = 0; i < 27; i++)
            alefbet = alefbet + (char)(1488 + i);

        for (int i = 10; i < alefbet.Length; i++)
        {
            switch (i)
            {
                case 10: alefbet = alefbet.Remove(10 - c1++, 1); break;
                case 13: alefbet = alefbet.Remove(13 - c1++, 1); break;
                case 15: alefbet = alefbet.Remove(15 - c1++, 1); break;
                case 19: alefbet = alefbet.Remove(19 - c1++, 1); break;
                case 21: alefbet = alefbet.Remove(21 - c1, 1); break;
            }
        }

        return alefbet;
    }

    //static string AlefBet(string alefbet)
    //{
    //    int c1 = 0;

    //    for (int i = 0; i < 27; i++)
    //        alefbet = alefbet + (char)(1488 + i);

    //    for (int i = 10; i < alefbet.Length; i++)
    //    {
    //        switch (i)
    //        {
    //            case 10: alefbet = alefbet.Remove(10 - c1++, 1); break;
    //            case 13: alefbet = alefbet.Remove(13 - c1++, 1); break;
    //            case 15: alefbet = alefbet.Remove(15 - c1++, 1); break;
    //            case 19: alefbet = alefbet.Remove(19 - c1++, 1); break;
    //            case 21: alefbet = alefbet.Remove(21 - c1, 1); break;
    //        }
    //    }

    //    return alefbet;
    //}

    static int[] GimatryNumber(string alefbet)
    {
        int[] gimatry = new int[alefbet.Length];
        int d = 1, count = 1;

        gimatry[0] = 1;
        for (int i = 1; i < alefbet.Length; i++)
        {
            gimatry[i] = gimatry[i - 1] + d;
            
            if ((i + count)/10 == count)
            {
                count++;
                d = d * 10;
            }
        }

        return gimatry;
    }

    static int SumString(string str)
    {
        string alefbet = AlefBet();
        int gimatrySum = 0, d = 1, count = 1;
        int temp = 0;

        int num;
        for (int i = 0; i < str.Length; i++)
        {
            num = 1;
            char s1 = str[i];
            char s2 = alefbet[num - 1];
            bool flag = true;
            while (flag)        // s1 != s2
            {
                temp = temp + d;
                if ((num + count - 1) / 10 == count)
                {
                    count++;
                    d = d * 10;
                }

                s2 = alefbet[num - 1];
                num++;

                if (s1 == s2) flag = false;
            }

            gimatrySum = gimatrySum + temp;

            d = 1;
            count = 1;
            temp = 0;
        }

        return gimatrySum;
    }

    static void PrintGimatryNumbers(string alefbet, int[] arr)
    {
        string[] letter = new string[alefbet.Length];
        for (int i = 0; i < alefbet.Length; i++)
        {
            letter[i] = alefbet[i].ToString();

            Console.WriteLine("{0} | {1}", letter[i], arr[i]);
        }
    }

    static void Main()
    {
        string str = "מוריס";

        SumString(str);

        int gimatryNumber = SumString(str);

        Console.WriteLine("The string is: {0}: gimatry number is: {1}", str, gimatryNumber);

        //string alefbet = "";

        //alefbet = AlefBet(alefbet);

        //int[] arr;

        //arr = GimatryNumber(alefbet);

        //PrintGimatryNumbers(alefbet, arr);

        //char ch;
        //ch = (char)1489;
        //Console.WriteLine(ch);

        Console.ReadKey();
    }
}