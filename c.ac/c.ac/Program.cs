using System;


public class codeacademy
{
    public static void Main()
    {
        int[][] array = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[]{ 7, 8, 9, }, new int[]{ 10, 11, 12, }, new int[] { 13, 14, 15, } };
{
        int sumofeven = 0;
        for (int i = 0; i < array.Length; i++ )
            {
                int[]arrayinside = array[i];
                foreach (int number in arrayinside)
                {
                    if (number % 2 != 1)
                    {
                        sumofeven += number;
                    }
                }
            }

        Console.WriteLine(sumofeven);
    }
}
    }