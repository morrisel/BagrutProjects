using System;

class Program
{
    static string ReadString()
    {
        string str = string.Empty;

        Console.Write("Enter some string: ");
        str = Console.ReadLine();

        return str;
    }

    static string ReverseString(string str)
    {
        string s1 = "", s2="", s3="";

        for (int i = 0; i < str.Length / 2; i++)
        {
            s1 = str.Substring(i, 1);
            s2 = str.Substring(str.Length - 1 - i, 1);

            str = str.Remove(i, 1);
            str = str.Insert(i, s2);

            str = str.Remove(str.Length - i - 1, 1);
            str = str.Insert(str.Length - i, s1);
        }

        return str;
    }

    static string SubStringsReverse(string str)
    {
        string subStr = "", tempStr = "";
        int location = 0;

        tempStr = str;
        str = "";

        if (tempStr.Length !=0)
        {
            for (int j = 0; j < tempStr.Length; j++)
            {
                if (tempStr.IndexOf('0') != -1)
                {
                    location = tempStr.IndexOf('0');

                    subStr = tempStr.Substring(0, location);

                    subStr = ReverseString(subStr);

                    tempStr = tempStr.Remove(0, location + 1);

                    str = str + subStr + "0";
                }
            }
        }


        if (tempStr.Length != 0)
            str = str + ReverseString(tempStr.Substring(0, tempStr.Length));

        return str;
    }

    //static string[] SubStringsReverse(string[] str)
    //{
    //    string subStr = "", tempStr = "";
    //    int location = 0;

    //    for (int i = 0; i < str.Length; i++)
    //    {
    //        tempStr = str[i];
    //        str[i] = "";
    //        //tempStr = "";
    //        if (tempStr != null && tempStr.IndexOf('0') != -1)
    //        {
    //            for (int j = 0; j < tempStr.Length; j++)
    //            {
    //                location = tempStr.IndexOf('0');

    //                subStr = tempStr.Substring(0, location);

    //                subStr = ReverseString(subStr);

    //                tempStr = tempStr.Remove(0, location + 1);

    //                str[i] = str[i] + subStr + "0";
    //                //tempStr = subStr;
    //                //str[i] = subStr;
    //            }
    //        }
    //        else
    //            continue;

    //        if (tempStr.Length != 0)
    //            str[i] = str[i] + tempStr;
    //    }

    //    return str;
    //}

    static void Main()
    {
        //string[] str=new string[5];
        string str1 = "";
        bool flag = true;

        Console.WriteLine("For quit from the program insert \"the end\"");

        while (flag == true)
        {
            str1 = ReadString();

            if (str1 == "the end")
            {
                flag = false;
                Console.WriteLine("You're quit from the program!");
            }
            else
            {
                Console.WriteLine("The string berfore reversing sub-stings is: {0}", str1);
                str1 = SubStringsReverse(str1);
                Console.WriteLine("The string after reversing sub-stings is: {0}", str1);
                Console.WriteLine("------------------------------------------------");
            }
        }
        
        //str[0] = "abcd0adsf0e";
        //str[1] = "b0y%S0ggg0";
        //str = SubStringsReverse(str);

        Console.ReadKey();
    }
}