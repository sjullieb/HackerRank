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

class Solution {

    // Complete the closestNumbers function below.
    static int[] closestNumbers(int[] arr) {

        List<int> results = new List<int>{};

        if(arr.Length >= 2){
            Array.Sort(arr);
            int currentMin = arr[arr.Length - 1] - arr[0];

            for(int i = 0; i < arr.Length - 1; i++)
            {
                int diff = arr[i+1] - arr[i];
                if(diff == currentMin)
                {
                    results.Add(arr[i]);
                    results.Add(arr[i+1]);
                }
                else if (diff < currentMin)
                {
                    currentMin = diff;
                    results.Clear();
                    results.Add(arr[i]);
                    results.Add(arr[i+1]);
                }
            }
        }

        return results.ToArray();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = closestNumbers(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
