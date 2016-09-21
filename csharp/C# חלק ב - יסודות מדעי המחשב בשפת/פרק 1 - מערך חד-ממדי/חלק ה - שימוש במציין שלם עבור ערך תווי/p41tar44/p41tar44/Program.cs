using System;


class Program
{
    public static void PrintMessage()
    {
        
    }
    public static void GetCharArray(char[] chArr)
    {
        bool[] isLetter = new bool[6];
        int count = 0;
        bool isWord = true;

        for (int i = 0; i < chArr.Length; i++)
        {

            switch (chArr[i])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        count = 0;
                        isLetter[i] = true;
                        break;
                    }
                default:
                    {
                        if (chArr[i] > 'a' && chArr[i] < 'z')
                        {
                            isLetter[i] = true;
                            count++;
                            if (count > 2)
                                isWord = false;
                        }
                        else
                        {
                            isLetter[i] = false;
                        }
                        break;
                    }
            }
        }

        int j = 0;

        if (!isWord)
            Console.WriteLine("The sentence doesn't legal");
        
        while (isWord && j < chArr.Length)
        {
            Console.Write("{0} ", chArr[j]);
            j++;
        }

    }

    static void Main()
    {
        char[] abc = new char[6];

        for (int i = 0; i < 6; i++)
        {
            abc[i] = char.Parse(Console.ReadLine());
        }

        GetCharArray(abc);

        Console.ReadKey();
    }
}