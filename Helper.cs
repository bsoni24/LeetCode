using System;

public class Helper
{
    public static void PrintArray(int[] array)
    {
        foreach (var a in array)
        {
            Console.Write(a + ",");
        }
    }
}