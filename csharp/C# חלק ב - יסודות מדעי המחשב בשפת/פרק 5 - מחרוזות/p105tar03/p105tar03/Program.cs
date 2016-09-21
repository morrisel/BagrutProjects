using System;

class Program
{
    static void PrintData(string[] listNames)
    {
        Console.WriteLine("Printing all names:");
        for (int i = 0; i < listNames.Length; i++)
            Console.WriteLine(listNames[i]);

        Console.WriteLine("------------------------------------");
    }

    static string[] GetNames(string[] listNames)
    {
        Console.WriteLine("Enter some names:");
        for (int i = 0; i < listNames.Length; i++)
            listNames[i] = Console.ReadLine();

        return listNames;
    }

    static void FindEmptyString(string[] listNames)
    {
        for (int i = 0; i < listNames.Length; i++)
            if (listNames[i] == "")
                listNames[i] = null;
    }

    static void AdditionalName(string[] listNames, string str)
    {
        for (int i = 0; i < listNames.Length; i++)
        {
            if (str.Equals(listNames[i]))
                Console.WriteLine("The name: " + str + " it finded");
            else
                if (listNames[i] == null || listNames[i] == "")
                    listNames[i] = str;
        }
    }

    static void Main()
    {
        string[] listNames = new string[5];
        string name;

        listNames = GetNames(listNames);

        FindEmptyString(listNames);

        Console.WriteLine("\nPrinting the names before adding");
        PrintData(listNames);

        Console.WriteLine("\nEnter another name: ");
        name = Console.ReadLine();

        AdditionalName(listNames, name);

        Console.WriteLine("Printing the names after adding");
        PrintData(listNames);
        
        Console.ReadKey();
    }
}