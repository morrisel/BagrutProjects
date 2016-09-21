using System;

class Program
{
    const int N = 80;

    // Methods
    public static int[] GetAverage(int[] avg, int[] passed)
    {
        int j = 0;

        for (int i = 0; i < avg.Length; i++)
        {
            Console.Write("Enter your average ");
            avg[i] = int.Parse(Console.ReadLine());
            if (avg[i] >= 80)
            {
                passed[j] = i;
                j++;
            }
        }

        return avg;
    }
    public static int[] SplitArray(int[] arr)
    {
        int[] newArray;
        int count = 0;


        for (int i = arr.Length - 1; i > 0; i--)
        {
            if (arr[i] == 0)
                count++;
            else
                break;
        }
        newArray = new int[arr.Length - count];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = arr[i];
        }

        return newArray;
    }
    public static void Print(int[] arr1, char[] arr2)
    {
        for (int i = 0; i < arr2.Length; i++)
        {
            switch (arr2[i])
            {
                case 'y':
                    Console.WriteLine("student " + (arr1[i] + 1) + " registered for graduate MBA");
                    break;
                case 'n':
                    Console.WriteLine("student " + (arr1[i] + 1) + " not registered for graduate to MBA");
                    break;
            }
        }
    }


    static void Main()
    {
        int[] avg = new int[N];
        int[] passed = new int[N];
        char[] answer;

        //------------------------------------------------- get average above 80 of the students 
        avg = GetAverage(avg, passed);

        passed = SplitArray(passed);
        answer = new char[passed.Length];

        Console.WriteLine("\nIf you're like to register for graduate MBA");
        for (int i = 0; i < passed.Length; i++)
        {
            Console.Write("press 'y' / 'n': ");
            answer[i] = char.Parse(Console.ReadLine());
        }

        //------------------------------------------------- print
        Print(passed, answer);

        Console.ReadKey();
    }
}