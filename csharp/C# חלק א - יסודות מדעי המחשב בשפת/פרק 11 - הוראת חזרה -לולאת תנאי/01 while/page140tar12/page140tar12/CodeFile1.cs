using System;

class CodeFile1
{
    static void Main(string[] args)
    {
        int hour, bonus = 0, count = 0;
        double rate, avg, salary = 0.0, sum = 0.0;

        Console.WriteLine("Workers of factory");
        Console.WriteLine("\n*for stop the program insert -999");
        Console.WriteLine("--------------------------------------\n");

        Console.Write("Enter the hours of work ");
        hour = int.Parse(Console.ReadLine());
        Console.Write("Insert the rate of hour: ");
        rate = double.Parse(Console.ReadLine());

        

        while (hour != -999 && rate != -999)
        {
            if (hour >= 150)
                bonus = bonus + 250;

            salary = hour * rate + bonus;
            sum = sum + salary;

            count++;

            Console.Write("\nEnter the hours of work ");
            hour = int.Parse(Console.ReadLine());
            Console.Write("Insert the rate of hour: ");
            rate = double.Parse(Console.ReadLine());
            
        }

        avg = sum / count;

        Console.WriteLine("\nThe total expenses of the owner of the factory for salary employees is: {0}", sum);
        Console.WriteLine("The average of the salary is: {0}", avg);


        Console.ReadKey();
    }
}