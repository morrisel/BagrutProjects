using System;

class Ch1TestMemory
{
    public static void NumToOne(int x)
    {
        x = 1;
    }

    public static void NumbersToOne(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = 1;
    }


    static void Main()
    {
        int num = 0;
        int[] numbers=new int[7];

        Console.WriteLine("Num before op = " + num);
        NumToOne(num);
        Console.WriteLine("Num after op = " + num);

        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = 0;

        Console.WriteLine("\nArray before op: ");
        for (int i = 0; i < numbers.Length; i++)
            Console.Write(numbers[i] + " ");

        Console.WriteLine();
        NumbersToOne(numbers);
        Console.WriteLine("\nArray after op: ");
        for (int i = 0; i < numbers.Length; i++)
            Console.Write(numbers[i] + " ");


        Console.ReadKey();
    }
}