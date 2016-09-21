using System;

class Program
{
    static void Print(int[] n, string[] s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("{0} : {1} ", s[i], n[i]);
        }
    }
    static void LengthSequence(string str)
    {
        int[] arr;
        string[] strArr;
        int len = 0, ct = 0;

        for (int i = 1; i < str.Length - 1; i++)
        {
            ct = 0;
            while (str[i - 1] == str[i] && i < str.Length - 1)
            {
                ct++;
                i++;
            }
            if (ct != 0)
                len++;
        }

        ct = 0;
        arr = new int[len];
        strArr = new string[len];
        bool flag = true;

        for (int i = 0; i < str.Length - 1; i++)
        {
            for (int j = 1; j < str.Length - 1; j++)
            {
                if (i + j < str.Length)
                {
                    if (str[i] == str[j + i])
                    {
                        arr[ct]++;
                        strArr[ct] = str[i].ToString();
                    }
                    else
                    {
                        i = j + i - 1;
                        break;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            if (arr[ct] != 0) ct++;

            if (!flag) break;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]++;
        }

        Print(arr, strArr);
    }

    static void Main()
    {
        string str = "aabccccaaacddd";

        //LengthSequence(str);

        LengthSequence("aabccccaaacdddf");   // not working

        Console.ReadKey();
    }
}