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

    // Complete the isBalanced function below.
    static string isBalanced(string s) {
        Stack<char> st = new Stack<char>();

        foreach(char bracket in s)
        {
            if ("{[(".IndexOf(bracket)>=0) // opening bracket
            {
                st.Push(bracket);
            }
            else if(st.Count == 0) // closing bracket, no opening
            {
                return "NO";
            }
            else if(((st.Peek() == '(') && (bracket == ')')) || ((st.Peek() == '{') && (bracket == '}')) || ((st.Peek() == '[') && (bracket == ']')))        
            {
                st.Pop();
            }
        }
        if (st.Count == 0)
            return "YES";
        return "NO";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
