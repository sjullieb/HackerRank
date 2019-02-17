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

    // Complete the minimumNumber function below.
    static int minimumNumber(int n, string password) {
        // Return the minimum number of characters to make the password strong
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";

        bool hasDigit = false;
        bool hasLowerCase = false;
        bool hasUpperCase = false;
        bool hasSpecialSymbol = false;

        int cryteriaSymbolsMissing = 4;

        foreach(char letter in password)
        {
            if (!(hasDigit) && (numbers.IndexOf(letter)>-1)){
                hasDigit = true;
                cryteriaSymbolsMissing--;
            }
            if (!(hasLowerCase) && (lower_case.IndexOf(letter)>-1)){
                hasLowerCase = true;
                cryteriaSymbolsMissing--;
            }
            if (!(hasUpperCase) && (upper_case.IndexOf(letter)>-1)){
                hasUpperCase = true;
                cryteriaSymbolsMissing--;
            }
            if (!(hasSpecialSymbol) && (special_characters.IndexOf(letter)>-1)){
                hasSpecialSymbol = true;
                cryteriaSymbolsMissing--;
            }
        }
        return Math.Max(cryteriaSymbolsMissing, 6-n);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
