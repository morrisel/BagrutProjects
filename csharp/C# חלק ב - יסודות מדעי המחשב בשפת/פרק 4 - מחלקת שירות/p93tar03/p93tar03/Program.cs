using System;

class Heap
{
    // 1:   0-פעולה מקבלת ערימת קלפים ומאתחלת כל קלף בערימת הקלפים ב
    public static void ResetDeckCards(int[] deck)
    {
        for (int i = 0; i < deck.Length; i++)
            deck[i] = 0;
    }

    // 2:   ערכים שונים של קלפים לתחילת הערימה n וקולטת n הפעולה מקבלת ערימת קלפים ומספר שלם
    public static void GiveDeck(int[] deck, int n)
    {
        Console.Write("Entered {0} cards", n);
        GenerateRandomNumbersForDeck(deck, n);
    }

    // 3:   קלפים שונים לערימה בתחום 1-13 שיהיו בתחילת הערימה n ומגרילה ,n הפעולה מקבלת ערימת קלפים ומספר שלם
    public static void GenerateRandomNumbersForDeck(int[] deck, int n)
    {
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j > 0; j--)
                deck[j] = deck[j - 1];

            deck[0] = rnd.Next(1, 14);
        }
    }

    // 4:   הפעולה מקבלת ערימת כלפים וקלפ ומוסיפה את הקלף בתחתית הערימה
    public static void InsertToBottom(int[] deck, int card)
    {
        //deck[deck.Length - 1] = card;

        //for (int i = 0; i < deck.Length - 1; i++)
        //{
        //    deck[i] = deck[i + 1];
        //}

        //deck[deck.Length - 1] = card;

        for (int i = 0; i < deck.Length; i++)
        {
            if (deck[i] == 0)
            {
                deck[i] = card;
                break;
            }
        }
    }

    // 5:   הפעולה מקבלת ערימת קלפים ומוציאה את הקלף מראש הערימה
    public static int GetFromTop(int[] deck)
    {
        int card = deck[0];

        for (int i = 1; i < deck.Length; i++)
        {
            deck[i - 1] = deck[i];

            if (deck[i] == 0)
                break;
        }

        deck[deck.Length - 1] = 0;

        return card;
    }

    // 6:   'הפלעולה מקבלת ערימת קלפים ומחזירה 'אמת' אם ערימה ריקה, אחרת 'שקר
    public static bool IsEmpty(int[] deck)
    {
        int count = 0;

        for (int i = 0; i < deck.Length; i++)
            if (deck[i] == 0)
                count++;

        if (count == deck.Length)
            return true;

        return false;
    }
}

class Program
{
    static void MoveAllCards(int[] cards)
    {
        for (int i = 1; i < cards.Length; i++)
            cards[i - 1] = cards[i];

        cards[cards.Length - 1] = 0;
    }

    static void Main()
    {
        int n = 15;
        //int m = 10;
        int[] p1 = new int[n];
        int[] p2 = new int[n];
        int card1, card2;
        int count = 0;
        int sessionGames = 1;

        // א.
        Heap.ResetDeckCards(p1);
        Heap.ResetDeckCards(p2);
        
        // הגרלת חפיסת קלפים
        Heap.GiveDeck(p1, n);
        Console.WriteLine(" for player 1");

        Heap.GiveDeck(p2, n);
        Console.WriteLine(" for player 2");

        while (!Heap.IsEmpty(p1) && !Heap.IsEmpty(p2))
        {
            card1 = Heap.GetFromTop(p1);
            card2 = Heap.GetFromTop(p2);

            if (card1 > card2)
            {
                Heap.InsertToBottom(p1, card1);
                //if (p1[p1.Length - 1] != 0)
                //    MoveAllCards(p1);
                Heap.InsertToBottom(p1, card2);
            }
            else
            {
                if (card1 < card2)
                {
                    Heap.InsertToBottom(p2, card2);
                    //if (p2[p2.Length - 1] != 0)
                    //    MoveAllCards(p2);
                    Heap.InsertToBottom(p2, card1);
                }
                else
                {
                    Heap.InsertToBottom(p1, p1[0]);
                    Heap.InsertToBottom(p2, p2[0]);
                }
            }
            card1 = 0;
            card2 = 0;
            
            if (count++ == 1000)
            {
                Console.WriteLine("---------------------------------------------");
                Heap.GiveDeck(p1, n);
                Console.WriteLine(" for player 1");

                Heap.GiveDeck(p2, n);
                Console.WriteLine(" for player 2");

                count = 0;
                sessionGames++;
            }
        }
        Console.WriteLine("\n=================== END THE GAME ===================\n");
        if (Heap.IsEmpty(p1))
            Console.WriteLine("The player 1 Lost the game");

        if (Heap.IsEmpty(p2))
            Console.WriteLine("The player 2 lost the game");

        Console.WriteLine("Session of games would be {0}", sessionGames);

        Console.ReadKey();
    }
}