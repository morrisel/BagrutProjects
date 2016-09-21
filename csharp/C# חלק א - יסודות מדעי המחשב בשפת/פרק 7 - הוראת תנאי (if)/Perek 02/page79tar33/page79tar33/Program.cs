using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page79tar33
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageFirstPrt, ageSecondPrt;
            char sexFirstPrt, sexSecondPrt;


            Console.Write("Enter an age of first participant ");
            ageFirstPrt = int.Parse(Console.ReadLine());
            Console.Write("Enter a sex of first participant, enter the \"m\" or \"f\" character: ");
            sexFirstPrt = char.Parse(Console.ReadLine());

            Console.Write("Enter an age of second participant ");
            ageSecondPrt = int.Parse(Console.ReadLine());
            Console.Write("Enter a sex of second participant, enter the \"m\" or \"f\" character: ");
            sexSecondPrt = char.Parse(Console.ReadLine());



            //
            // Age of first and second participants of Group A
            //
            if (ageFirstPrt > 0 && ageFirstPrt < 8)
            {
                Console.Write("The age of first participant is: {0} he is belong to Group A\n", ageFirstPrt);
            }
            if (ageSecondPrt > 0 && ageSecondPrt < 8)
            {
                Console.Write("The age of second participant is: {0} he is belong to Group A\n", ageSecondPrt);
            }

            //
            // Age of first and second participants of Group B
            //
            if (ageFirstPrt >= 8 && ageFirstPrt < 13)
            {
                Console.Write("The age of first participant is: {0} he is belong to Group B\n", ageFirstPrt);
            }
            if (ageSecondPrt >= 8 && ageSecondPrt < 13)
            {
                Console.Write("The age of first participant is: {0} he is belong to Group B\n", ageFirstPrt);
            }

            //
            // Age of first and second participants of Group C
            //
            if (ageFirstPrt > 0 && ageFirstPrt < 8)
            {
                Console.Write("The age of first participant is: {0} he is belong to Group C\n", ageFirstPrt);
            }
            if (ageSecondPrt > 0 && ageSecondPrt < 8)
            {
                Console.Write("The age of first participant is: {0} he is belong to Group C\n", ageFirstPrt);
            }




            if (sexFirstPrt != sexSecondPrt)
            {
                Console.Write("The sex of first participant is: {0}\n", sexFirstPrt);
                Console.Write("The sex of second participant is: {0}\n", sexSecondPrt);
            }
            else
            {
                Console.WriteLine("The same sex of participant it doesn't match.");
                Console.WriteLine("Do you need to chage it for competition");
            }



            if (((ageFirstPrt > 0 && ageFirstPrt < 8) && (ageSecondPrt > 0 && ageSecondPrt < 8)) && (sexFirstPrt != sexSecondPrt))          // Group A
            {
                Console.WriteLine("\nThey are participants matching for competition");
            }

            if (((ageFirstPrt >= 8 && ageFirstPrt < 13) && (ageSecondPrt >= 8 && ageSecondPrt < 13)) && (sexFirstPrt != sexSecondPrt))      // Group B
            {
                Console.WriteLine("\nThey are participants matching for competition");
            }

            if (((ageFirstPrt >= 13 && ageFirstPrt <= 17) && (ageSecondPrt >= 13 && ageSecondPrt <= 17)) && (sexFirstPrt != sexSecondPrt))  // Group C
            {
                Console.WriteLine("\nThey are participants matching for competition");
            }


            Console.ReadKey();
        }
    }
}
