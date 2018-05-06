using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] horses = new int[N];
        int diff = int.MaxValue;
        int previous=0;
        for (int i = 0; i < N; i++)
        {
            horses[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(horses);
        for(int i=1;i<N;i++)
        {
            previous = horses[i]-horses[i-1];
            if(previous < diff) diff = previous;
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(diff);
    }
}
