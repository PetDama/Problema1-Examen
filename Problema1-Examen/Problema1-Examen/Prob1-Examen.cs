using System;

class Test
{

    static int[] arr = { 1, 2, 3, 4, 5 };


    static int findSum(int[] X, int Y)
    {
        if (Y <= 0)
            return 0;
        return (findSum(X, Y - 1) + X[Y - 1]);
    }

    public static void Main()
    {
        Console.Write(findSum(arr, arr.Length));
    }
}