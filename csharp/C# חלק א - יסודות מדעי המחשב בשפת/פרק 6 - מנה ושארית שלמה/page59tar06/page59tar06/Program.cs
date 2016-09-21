using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace page59tar06
{
    class Program
    {
        static void Main(string[] args)
        {
            int allMembers;
            int round1, round2;
            int outRound1Member, stayRound2Member;

            Console.WriteLine("\nEnter all members of the game \"7 Boom\" \n");
            allMembers = int.Parse(Console.ReadLine());

            round1 = allMembers / 7;                // מספר המשתתפים שיצאו בסיסוב הראשון
            round2 = (allMembers - round1) % 7;     // מספר המשתתפים שנשארו בסיסבוב השני

            outRound1Member = round1;
            stayRound2Member = round2;
            Console.WriteLine("The numbers of members that outgoing in first round is: {0}", outRound1Member);
            Console.WriteLine("The numbers of members that stayed for second round is: {0}", stayRound2Member);

            Console.ReadKey();
        }
    }
}
