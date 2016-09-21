using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar26
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOffer, seconOffer, thirdOffer, fourthOffer;
            

            Console.Write("Enter a first offer for car: ");
            firstOffer = int.Parse(Console.ReadLine());

            Console.Write("Enter a second offer for car: ");
            seconOffer = int.Parse(Console.ReadLine());

            Console.Write("Enter a third offer for car: ");
            thirdOffer = int.Parse(Console.ReadLine());
            
            Console.Write("Enter a fourth offer for car: ");
            fourthOffer = int.Parse(Console.ReadLine());

            if ((firstOffer > seconOffer) && (firstOffer > thirdOffer) && (firstOffer > fourthOffer))
                Console.WriteLine("The buyer who offered the sum {0}, he got the car ", firstOffer);

            if ((seconOffer > firstOffer) && (seconOffer > thirdOffer) && (seconOffer > fourthOffer))
                Console.WriteLine("The buyer who offered the sum {0}, he got the car", seconOffer);

            if ((thirdOffer > firstOffer) && (thirdOffer > seconOffer) && (thirdOffer > fourthOffer))
                Console.WriteLine("The buyer who offered the sum {0}, he got the car", thirdOffer);

            if ((fourthOffer > firstOffer) && (fourthOffer > seconOffer) && (fourthOffer > thirdOffer))
                Console.WriteLine("The buyer who offered the sum {0}, he got the car", fourthOffer);



            Console.ReadKey();
        }
    }
}
