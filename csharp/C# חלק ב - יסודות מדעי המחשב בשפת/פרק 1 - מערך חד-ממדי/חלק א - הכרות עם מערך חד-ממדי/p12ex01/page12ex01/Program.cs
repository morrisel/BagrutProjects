using System;

class Program
{
    /*קלט: קליטת ערך לתא הראשון אל תוך המערך*/
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter a number");
        numbers[0] = int.Parse(Console.ReadLine());

        for (int i = 1; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i - 1] + i;
            Console.WriteLine(numbers[i]);
        }

        Console.ReadKey();
    }
}