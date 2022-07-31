using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] foo = { 0, 1, 2, 3, 4 };
        int[] bar = new int[100];
        for (int i = 0; i < 100; i++)
        {
            bar[i] = i;
        }
        Console.WriteLine($"The total number of even numbers in foo are: {countEvenNum(foo, 5)}");

        Console.WriteLine($"The total number of even numbers in bar are: {countEvenNum(bar, 100)}");

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