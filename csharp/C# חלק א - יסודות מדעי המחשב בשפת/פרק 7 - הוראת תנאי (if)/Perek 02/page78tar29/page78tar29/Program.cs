using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page78tar29
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageMale, ageFemale;
            char male = 'm', female = 'f';
            int difference;
            char tempSex1, tempSex2;

            Console.WriteLine("The age of people can't be more than 5 years old");
            Console.WriteLine("The sex of people can be \"male and female\" or \"female and male\" \n");

            // גיל האנשים
            Console.Write("Enter the age of male ");
            ageMale = int.Parse(Console.ReadLine());
            Console.Write("Enter the age of female ");
            ageFemale = int.Parse(Console.ReadLine());
            if (ageMale >= ageFemale)
            {
                difference = ageMale - ageFemale;
            }
            else
            {
                difference = ageFemale - ageMale;
            }

            // מין האנשים
            Console.Write("Enter a sex: \"m\" or \"f\":  ");
            tempSex1 = char.Parse(Console.ReadLine());
            Console.Write("Enter a sex: \"m\" or \"f\":  ");
            tempSex2 = char.Parse(Console.ReadLine());
            if ((difference <= 5) && (((male == tempSex1) && (female == tempSex1)) || ((female == tempSex2) && (male == tempSex2))))
            {
                Console.WriteLine("The pairs is matching");
            }
            else
            {
                Console.WriteLine("The pairs isn't matching");
            }

            Console.ReadKey();
        }
    }
}
