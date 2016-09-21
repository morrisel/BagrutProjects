using System;

class Program
{
    public static bool GetCharAndLength(char[] N, int len)
    {
        int count = 0;
        int firstNewIndex = 0, secondNewIndex = 0;
        int distance;

        for (int i = 0; i < N.Length; i++)
        {
            // '$' כמה פעמים מופיע התו
            if (N[i] == '$')
                count++;

            if (count == 1 && N[i] == '$')
                firstNewIndex = i;

            if (count > 1 && N[i] == '$')
                secondNewIndex = i;
        }

        distance = Math.Abs(firstNewIndex - secondNewIndex) + 1;

        if (len == distance)
            return true;
        else
            return false;
    }


    static void Main()
    {
        int len;
        //char[] w = { '$', '$', '$' };
        //char[] w = { 'd', 's', '4', '$', '$', '$', '4', 's', 'd' };
        char[] w = { 'a', 'b', 'c', '$', 'a', 'x', 'y', '$', 'b', 'x', 'a', '$', 'v' };
        Console.Write("Enter a number: ");
        len = int.Parse(Console.ReadLine());

        //GetCharAndLength(w, len);

        Console.WriteLine(GetCharAndLength(w, len));

        Console.ReadKey();
    }
}