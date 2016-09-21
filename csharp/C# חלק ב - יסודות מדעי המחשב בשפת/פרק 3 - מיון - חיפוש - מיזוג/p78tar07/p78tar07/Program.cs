using System;

class Program
{
    static void Print()
    {

    }

    static int[] GenerateWorkersId(int[] workerId)
    {
        Random rnd = new Random();

        for (int i = 0; i < workerId.Length; i++)
        {
            workerId[i] = rnd.Next(1000, 5000);
        }

        return workerId;
    }

    static int[] GenerateExpirience(int[] seniority)
    {
        Random rnd = new Random();

        for (int i = 0; i < seniority.Length; i++)
        {
            seniority[i] = rnd.Next(1, 30);
        }

        return seniority;
    }

    static void SelectionSort(int[] seniority, int len)
    {
        int[] workerId = new int[len];
        int tempIndex, tempElem;

        workerId = GenerateWorkersId(workerId);

        for (int i = 0; i < len - 1; i++)
        {
            tempIndex = i;
            for (int j = i+1; j < len; j++)
            {
                if (seniority[j] < seniority[tempIndex])
                {
                    tempIndex = j;
                }
            }

            // מסדר את המערך לפי ותק
            tempElem = seniority[i];
            seniority[i] = seniority[tempIndex];
            seniority[tempIndex] = tempElem;

            // מסדר את המערך של מספרי העובדים בהתאם לסידור הותק
            tempElem = workerId[i];
            workerId[i] = workerId[tempIndex];
            workerId[tempIndex] = tempElem;
        }
    }

    static void Print(int[] workerId, int[] seniority)
    {
        int i = 0, j = workerId.Length - 10;

        while (i < 5 || j != workerId.Length)
        {
            if (i < 5)
            {
                Console.WriteLine("WorkerId = {0}, \tSeniority = {1}", workerId[i], seniority[i]);
                i++;
            }
            else
            {
                Console.WriteLine("WorkerId = {0}, \tSeniority = {1}", workerId[j], seniority[j]);
                j++;
            }

        }
        
    }


    static void Main()
    {
        int[] workerId = new int[20];
        int[] seniority = new int[20];
        int len;

        len = workerId.Length;
        workerId = GenerateWorkersId(workerId);
        seniority = GenerateExpirience(seniority);

        SelectionSort(seniority, len);

        Print(workerId, seniority);

        Console.ReadKey();
    }
}