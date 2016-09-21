using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page70tar15
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstScore, secondScore, totalScore;

            Console.WriteLine("Enter the score of first half and second half of student\n");

            Console.Write("The score of first half of studying is: ");
            firstScore = double.Parse(Console.ReadLine());

            Console.Write("The score of second half of studying is: ");
            secondScore = double.Parse(Console.ReadLine());

            if (firstScore < secondScore)
            {
                secondScore = secondScore * 0.9;
                firstScore = firstScore * 0.1;
                totalScore = secondScore + firstScore;
                Console.WriteLine("The score of student is: {0}", totalScore);
            }
            else
            {
                totalScore = (double)(firstScore + secondScore) / 2;
                Console.WriteLine("The score of student is: {0}", totalScore);
            }





            Console.ReadKey();
        }
    }
}
