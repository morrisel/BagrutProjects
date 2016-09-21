using System;

class Program
{
    static void Main()
    {
        Random randNum = new Random();
        int i = 0;
        //int[] a = { 6, -3, 0, -3 };
        int[] a = { 6, 3, 0, -3 };
        //int[] a = { 1, 3, 4, -3 };
        //int[] a = new int[4];

        int[] tempArr = new int[4];

        Console.Write("\na: ");
        // סורקת את איברי המערך הנוכחי while לולאת
        while (i < 4)
        {
            int num = randNum.Next((1 - i) * 3);
            num = num + 3;

            if (a[i] == num)
            {
                tempArr[i] = a[i];
                Console.Write(" {0}", tempArr[i]);
                i++;
            }
        }

        Console.ReadKey();
    }
}