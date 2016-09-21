using System;

class Program
{
    //public static char[] GetWord(int[] arr)
    //{
    //    char[] ch = new char[9];
    //    int[] indexArr = new int[26];
    //    int reminder, divider;

    //    for (int i = 0; i < 26; i++)
    //    {
    //        if (arr[i] != 0)
    //        {
    //            if (arr[i] > 9)
    //            {
    //                reminder = arr[i] % 10;
    //                divider = arr[i] / 10;
    //            }
    //            else
    //            {
    //                //ch['a' + i] = (char)arr[i];
    //            }
    //        }
    //    }


    //    return ch;
    //}

    public static char[] GetWord(int[] arr)
    {
        char[] ch = new char[9];
        int rem, div;

        for (int i = 0; i < ch.Length; i++)
        {
            ch[i] = ' ';
        }

        for (int i = 0; i < 26; i++)
        {
            if (arr[i] != 0)
            {
                if (arr[i] > 9)
                {
                    rem = arr[i] % 10;
                    div = arr[i] / 10;
                    ch[rem] = (char)('a' + i);
                    ch[div] = (char)('a' + i);
                }
                else
                {
                    ch[arr[i]] = (char)('a' + i);
                    //ch['a' + i] = (char)arr[i];
                }
            }
        }

        return ch;
    }

    static void Main()
    {
        char[] word = new char[9];
        int[] myArr = new int[26];

        // enter a number 1 between 99
        //myArr[4] = 2;
        //myArr[7] = 1;
        //myArr[11] = 34;
        //myArr[14] = 5;
        myArr[3] = 13;
        myArr[8] = 2;


        word = GetWord(myArr);


        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word[i]);
        }

        Console.ReadKey();
    }
}