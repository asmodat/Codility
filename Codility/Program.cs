using Codility.Arrays;
using Codility.Iterations;
using Codility.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryGap.solution(1041); //5
            //BinaryGap.solution(12343); //6
            //CyclicRotations.solution(new int[] { 3, 8, 9, 7, 6 }, 3);

            //CountDiv.solution(0, 1, 1);

            // Random rnd = new Random((int)DateTime.Now.Ticks);
            // int[] at = Enumerable.Repeat(0, 100000).Select(i2 => rnd.Next(-10000, 10001)).ToArray();
            // int t1 = MinAvgTwoSlice.solution(at);
            // int t2 = MinAvgTwoSlice.solution1(at);
            Random rnd = new Random((int)DateTime.Now.Ticks);
            string S = "CGCCCCCGGGGGGGGCCGGCCGGCGCATATTATACTCCTTCCTTTATGGGGGGCCGGCCGGCGCATATTATACTCCTTCCTTTATATGTGTGTGTGGCGCGCGAATATCCCCCCTCCTTCCTTTATATGTGTGTGTGGCGCCCCTTTTTTACGTACGGACTGACTTACGTACGGACT";

            for (int i = 0; i < 1000; i++)
            {
                /*int size = rnd.Next(2, S.Length);
                int[] P = new int[size];
                int[] Q = new int[size];

                for (int i2 = 0; i2 < size; i2++)
                {
                    int v = rnd.Next(0, size);
                    int v2 = rnd.Next(0, size);
                    P[i2] = Math.Min(v, v2);
                    Q[i2] = Math.Max(v, v2);
                }*/


                int[] P = new int[] { 1,5,7,8 };
                int[] Q = new int[] { 3,8,11,15 };


                int[] t1 = GeometricRangeQuery.solution(S, P, Q);
                int[] t2 = GeometricRangeQuery.solution1(S, P, Q);

                CollectionAssert.AreEqual(t1, t2, "fail");
            }




            Console.Read();
        }
    }
}
