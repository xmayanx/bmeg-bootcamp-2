using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 0, 1, 2, 3, 4 };
        int[] array2 = new int[100];
        for (int i = 0; i < 100; i++)
        {
            array2[i] = i;
        }
        Console.WriteLine($"The total number of even numbers in array1 are: {countEvenNum(array1, 5)}");

        Console.WriteLine($"The total number of even numbers in array2 are: {countEvenNum(array2, 100)}");

    }

    static int countEvenNum(int[] arr, int size)
    {
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }

        }
        return count;
    }
}