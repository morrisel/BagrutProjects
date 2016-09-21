using System;

//Grass areas
class CodeFile1
{
    static void Main(string[] args)
    {
        int lenght, weight;
        int area = 0, sum = 0, count = 0;

        while (area <= 500)
        {
            Console.Write("Enter a lenght of area: ");
            lenght = int.Parse(Console.ReadLine());

            Console.Write("Enter a weight of area: ");
            weight = int.Parse(Console.ReadLine());

            area = area + (lenght * weight);
            sum = sum + 30;
            count++;
        }

        Console.WriteLine("The number of grass area that have been buying is: {0}", count);
        Console.WriteLine("The sum for these grasses area is: {0}", sum);

        Console.ReadKey();
    }
}