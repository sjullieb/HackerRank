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

    static string FindNextStringNumber(string str)
    {
        string result = "";
        int ten = 1;
        int sum;
      //  Console.WriteLine("str {0}  ", str);
        for(int i = str.Length - 1; i >= 0; i--)
        {
            sum = int.Parse(str[i].ToString());    
            result = ((sum + ten)%10).ToString() + result;
            ten = (sum+ten)/10;
           // Console.WriteLine("{0}  {1}", (sum+ten)%10, result);
        }
        if(ten == 1)
            result = "1" + result;
      //  Console.WriteLine("{0}  {1}", str, result);
        return result;
    }

    // Complete the separateNumbers function below.
    static void separateNumbers(string s) {
        string arr = s;
        string result = "";
        if (arr.Length <= 1)
            result = "NO";
        else if (arr[0] == '0')
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
//                string firstNumber = arr.Substring(0, i);                    
                string currentBeautiful = arr.Substring(0, i);
                string currentNumber = currentBeautiful;
                do {
                    currentNumber = FindNextStringNumber(currentNumber);
                    currentBeautiful += currentNumber;
                    //Console.WriteLine("{0}", currentBeautiful);
                
                } while ((currentBeautiful.Length <= arr.Length) && (arr.Substring(0, currentBeautiful.Length) == currentBeautiful));
                
                //Console.WriteLine("out {0}", currentBeautiful);
                if(currentBeautiful.Substring(0, currentBeautiful.Length - currentNumber.Length) == arr)
                    result = "YES " + firstNumber;
            }
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
