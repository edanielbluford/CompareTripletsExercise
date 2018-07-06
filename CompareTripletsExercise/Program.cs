using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the solve function below.
    static int[] Solve(int[] a, int[] b)
    {
        a = new int[] { 5, 6, 7 };
        b = new int[] { 3, 6, 10 };
        int alice = 0;
        int bob = 0;


        foreach (var item in a)
        {
            if (a[item] > b[item])
            {
                alice++;
            }
            else if (a[item] < b[item])
            {
                bob++;
            }
            else
            {
                Console.WriteLine("You get nothing!");
            }
   
        }
        return ;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int[] result = Solve(a, b);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}