using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b) {
        if ((a.Length == 0) || (b.Length == 0))
            return 0;

        int count = 0;
        for(int i = a[a.Length - 1]; i <= b[0]; i++)
        {
            int j = -1;
            do
            {j++;}
            while ((j < a.Length) && (i%a[j] == 0));

            if(j == a.Length)
            {
                int k = -1;
                do
                {k++;}
                while((k < b.Length) && (b[k]%i == 0));

                if (k == b.Length)
                    count++;
            }
        }
        return count;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
