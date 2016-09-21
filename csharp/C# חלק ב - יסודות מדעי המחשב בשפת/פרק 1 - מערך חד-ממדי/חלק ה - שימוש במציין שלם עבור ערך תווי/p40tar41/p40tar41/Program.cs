using System;

class Program
{
    static int Vitamins(bool[] cereal)
    {
        int count = 0;
        for (int i = 0; i < cereal.Length; i++)
        {
            if (cereal[i])
                count++;
            //else
            //    count--;
        }

        return count;
    }

    static void VitaminsPrint(bool[] cereal)
    {
        int num;
        char ch;

        for (int i = 0; i < cereal.Length; i++)
        {
            if (cereal[i])
            {
                num = (int)'a' + i;
                ch = (char)num;
                Console.Write(ch + " ");
                //letter[i] = (char)num;
                //Console.Write(letter[i] + " ");
            }
        }
    }

    static void Main()
    {
        bool[] cereal = new bool[5];
        char[] letter = new char[5];
        char ch;


        for (int i = 0; i < letter.Length; i++)
        {
            ch = char.Parse(Console.ReadLine());
            letter[ch - 'a'] = '+';
        }

        Console.WriteLine();

        for (int i = 0; i < letter.Length; i++)
        {
            if (letter[i] == '+')
                cereal[i] = true;
        }

        VitaminsPrint(cereal);

        Console.ReadKey();
    }
}