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


//----------------------------------------------------
// WORKS FOR SHORT STRINGS ONLY
//----------------------------------------------------
    static void separateNumbers(string s) {
        string arr = s;
        string result = "";
        if (arr.Length <= 1)
            result = "NO";
        else
        for(int i = 1; i <= (arr.Length)/2; i++)
        {
            if (result != "")
            {
                break;
            }
            if  (((arr[i-1] < '0') && (arr[i-1] > '9')))
            {
                result = "NO";
                break;
            }
            else
            {
                string firstNumber = arr.Substring(0, i);        
        // ---------------- version 1 -------------------
            //   string currentBeautiful = firstNumber;
            //   int currentNumber = int.Parse(currentBeautiful);
            //   currentNumber++;
            //   currentBeautiful += currentNumber.ToString();

            //   while ((currentBeautiful.Length != arr.Length) && (arr.Substring(0, currentBeautiful.Length) == currentBeautiful))
            //   {
            //     currentNumber++;
            //     currentBeautiful += currentNumber.ToString();
            //   }

            //   if(currentBeautiful == arr)
            //     Console.WriteLine("YES " + firstNumber);

        // ---------------- version 2 -------------------

                string currentBeautiful = arr.Substring(0, i);
                int currentNumber = int.Parse(currentBeautiful);
                do {
                    currentNumber++;
                    currentBeautiful += currentNumber.ToString();
                    //Console.WriteLine("{0}", currentBeautiful);
                
                } while ((currentBeautiful.Length <= arr.Length) && (arr.Substring(0, currentBeautiful.Length) == currentBeautiful));
                
                //Console.WriteLine("out {0}", currentBeautiful);
                if(currentBeautiful.Substring(0, currentBeautiful.Length - (currentNumber.ToString()).Length) == arr)
                    result = "YES " + firstNumber;
            }
    // -----------------------------------------------
        }
        if (result == "")
            result = "NO";
        Console.WriteLine(result);
    }

    static void Main(string[] args) {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            separateNumbers(s);
        }
    }
}
