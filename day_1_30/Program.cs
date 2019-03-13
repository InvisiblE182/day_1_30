using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int ii = 0;
        double dd = 0.0;
        string ss = "";
        // Declare second integer, double, and String variables.
        ii = Convert.ToInt32(Console.ReadLine());
        dd = Convert.ToDouble(Console.ReadLine());
        ss = Console.ReadLine();
        // Read and save an integer, double, and String to your variables.
        Console.WriteLine((i + ii).ToString());
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(string.Format("{0:F1}", d + dd));
        // Print the sum of the double variables on a new line.
        string.Format("{0:F1}", 6.33);
        Console.WriteLine(s + ss);
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}