using System;

class SetTheory
{
    // 1.   A ∩ B
    public static int[] Intersection(int[] A, int[] B)
    {
        int lenIntersection, count = 0;

        lenIntersection = (A.Length < B.Length) ? A.Length : B.Length;

        int[] C = new int[lenIntersection];

        for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < B.Length; j++)
                if (A[i] == B[j])
                    C[count++] = B[j];

        return C;
    }

    // 2.   A ∪ B
    public static int[] Union(int[] A, int[] B)
    {
        int count = 0;
        bool isFind = true;

        int[] C = new int[A.Length + B.Length];

        for (int i = 0; i < A.Length; i++)
            C[count++] = A[i];

        for (int i = 0; i < B.Length; i++)
        {
            isFind = true;
            for (int j = 0; j < A.Length; j++)
                if (B[i] == A[j])
                    isFind = false;

            if (isFind)
                C[count++] = B[i];
        }

        return C;
    }

    // 3.   A ∖ B
    public static int[] Complement(int[] A, int[] B)
    {
        int[] C = new int[A.Length];
        //int[] union = new int[A.Length + B.Length];
        int count = 0;
        bool isFind;

        //union = Union(A, B);

        for (int i = 0; i < C.Length; i++)
        {
            isFind = false;
            for (int j = 0; j < B.Length; j++)
                if (A[i] == B[j])
                    isFind = true;

            if (!isFind)
                C[count++] = A[i];
        }
        return C;
    }

    // 4.   A ⊇ B
    public static bool SubSet(int[] A, int[] B)
    {
        int count = 0;

        for (int i = 0; i < B.Length; i++)
            for (int j = 0; j < A.Length; j++)
                if (B[i] == A[j])
                    count++;

        if (count == B.Length)
            return true;

        return false;
    }

    // 6.   merge
    public static int[] Merge(int[] A, int[] B)
    {
        int pmin = 0, temp;
        int[] C = new int[A.Length + B.Length];

        C = Union(A, B);

        for (int i = 0; i < C.Length - 1; i++)
        {
            pmin = i;
            for (int j = i + 1; j < C.Length; j++)
            {
                if (C[j] < C[pmin] && C[j] != 0)
                    pmin = j;
            }

            temp = C[i];
            C[i] = C[pmin];
            C[pmin] = temp;
        }

        return C;
    }

    public static void Write(int[] a)
    {
        Console.Write("The array value is: ");
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,4}", a[i]);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        //int[] A = { 5, 7, 8, 12 };
        int[] A = { 5, 7, 8, 12, 2, 3, 9, 11, 15, 20 };
        int[] B = { 2, 3, 5, 7, 9, 11, 12, 15 };
        int[] C;
        bool isSet;

        Console.Write("A: ");
        SetTheory.Write(A);
        Console.Write("B: ");
        SetTheory.Write(B);
        Console.WriteLine("---------------------------------------------------------\n");

        // 1
        C = SetTheory.Intersection(A, B);
        Console.WriteLine("Intersection(A, B):");
        SetTheory.Write(C);

        // 2
        C = SetTheory.Union(A, B);
        Console.WriteLine("\nUnion(A, B):");
        SetTheory.Write(C);

        // 3
        C = SetTheory.Complement(A, B);
        Console.WriteLine("\nComplement(A, B):");
        SetTheory.Write(C);

        // 4
        isSet = SetTheory.SubSet(A, B);
        Console.WriteLine("\nSubSet(A, B):");
        Console.WriteLine("B subset A is: " + isSet);

        // 5
        C = SetTheory.Merge(A, B);
        Console.WriteLine("\nMerge(A, B):");
        SetTheory.Write(C);

        Console.ReadKey();
    }
}
