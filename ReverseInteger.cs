using System;
using System.Collections.Generic;

public class ReverseInteger
{
    //https://leetcode.com/problems/reverse-integer/

    //     Console.WriteLine(ReverseInteger.Option1(123));
    //     Console.WriteLine(ReverseInteger.Option1(-123));
    //     Console.WriteLine(ReverseInteger.Option1(120));
    //     Console.WriteLine(ReverseInteger.Option1(0));
    //     Console.WriteLine(ReverseInteger.Option1(1534236469));
    public static int Option1(int x)
    {
        int answer = 0;

        while (x != 0)
        {
            var pop = x % 10;

            if (answer > int.MaxValue / 10 || answer == int.MaxValue && pop > 7) return 0;
            if (answer < int.MinValue / 10 || answer == int.MinValue && pop > -8) return 0;

            answer = answer * 10 + pop;
            x = x / 10;
        }
        return answer;
    }
}