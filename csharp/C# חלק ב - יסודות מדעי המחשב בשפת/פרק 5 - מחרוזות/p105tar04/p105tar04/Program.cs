using System;

class Program
{
    static void PrintData(string[] listOfNames)
    {
        Console.WriteLine("Printing all names:");
        for (int i = 0; i < listOfNames.Length; i++)
            Console.WriteLine(listOfNames[i]);

        Console.WriteLine("------------------------------------");
    }

    static string[] GetNames(string[] listOfNames)
    {
        Console.WriteLine("Enter some names:");
        for (int i = 0; i < listOfNames.Length; i++)
            listOfNames[i] = Console.ReadLine();

        return listOfNames;
    }

    static void FindEmptyString(string[] listOfNames)
    {
        for (int i = 0; i < listOfNames.Length; i++)
            if (listOfNames[i] == "")
                listOfNames[i] = null;
    }

    static void AddingNames(string[] listOfNames, string str)
    {
        for (int i = 0; i < listOfNames.Length; i++)
        {
            if (str.Equals(listOfNames[i]))
                Console.WriteLine("The name: " + str + " it finded");
            else
                if (listOfNames[i] == null || listOfNames[i] == "")
                    listOfNames[i] = str;
        }
    }

    static void BubbleSort(string[] listOfNames)
    {
        string tempStr;
        int n;
        string st1, st2;
        
        for (int i = 0; i < listOfNames.Length - 1; i++)
        {
            for (int j = 0; j < listOfNames.Length - i - 1; j++)
            {
                st1 = listOfNames[j];
                st2 = listOfNames[j + 1];

                n = st1.CompareTo(st2);

                if (st1.CompareTo(st2) > 0)
                {
                    tempStr = listOfNames[j];
                    listOfNames[j] = listOfNames[j + 1];
                    listOfNames[j + 1] = tempStr;
                }
            }
        }
    }

    static void Main()
    {
        string[] listOfNames = new string[7];
        string name;

        listOfNames = GetNames(listOfNames);

        //FindEmptyString(listOfNames);

        //Console.WriteLine("\nPrinting the names before adding");
        //PrintData(listOfNames);

        //Console.WriteLine("\nEnter another name: ");
        //name = Console.ReadLine();

        //AddingNames(listOfNames, name);

        Console.WriteLine("Printing the names after adding");
        PrintData(listOfNames);

        // order all of the names - Bubble Sort
        BubbleSort(listOfNames);
        PrintData(listOfNames);

        Console.ReadKey();
    }
}