using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Iterations;
using Codility.PrefixSums;

namespace CodilityUnitTests.PrefixSums
{
    [TestClass]
    public class PrefixSums
    {

        [TestMethod]
        public void GeometricRangeQueryTest()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);

            string S = "CGCCCCCGGGGGGGGCCGGCCGGCGCATATTATACTCCTTCCTTTATGGGGGGCCGGCCGGCGCATATTATACTCCTTCCTTTATATGTGTGTGTGGCGCGCGAATATCCCCCCTCCTTCCTTTATATGTGTGTGTGGCGCCCCTTTTTTACGTACGGACTGACTTACGTACGGACT";

            for (int i = 0; i < 1000; i++)
            {
                int size = rnd.Next(2, S.Length);
                int[] P = new int[size];
                int[] Q = new int[size];

                for(int i2 = 0; i2 < size; i2++)
                {
                    int v = rnd.Next(0, size);
                    int v2 = rnd.Next(0, size);
                    P[i2] = Math.Min(v, v2);
                    Q[i2] = Math.Max(v, v2);
                }

                
                int[] t1 = GeometricRangeQuery.solution(S,P,Q);
                int[] t2 = GeometricRangeQuery.solution1(S,P,Q);

                CollectionAssert.AreEqual(t1, t2, "fail");
            }
        }




        [TestMethod]
        public void MinAvgTwoSliceTest()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int min = -10000;
            int max = 10000;
         
            for(int i = 0; i < 10000; i++)
            {
                int[] at = Enumerable.Repeat(0, rnd.Next(2, 101)).Select(i2 => rnd.Next(min, max + 1)).ToArray();
                int t1 = MinAvgTwoSlice.solution(at);
                int t2 = MinAvgTwoSlice.solution1(at);
                Assert.AreEqual(t1, t2, 0, $"Result: [ex:{t2} ,go: {t1}]");
            }
        }




        [TestMethod]
        public void CountDivTest()
        {
            Console.WriteLine("Start");

            int t1, t2;
            for(int a = 100; a < 200; a++)
            {
                for (int b = 100; b < 200; b++)
                {
                    if (b < a) continue;
                    for (int k = 1; k < 101; k++)
                    {
                        t1 = CountDiv.solution1(a, b, k);
                        t2 = CountDiv.solution(a, b, k);
                        Assert.AreEqual(t1,t2, 0, $"Result: {a}-{b}-{k}: [ex:{t1} ,go: {t2}]");
                    }
                }
            }

            CountDiv.solution1(1, 1, 1);

           // Random r = new Random(DateTime.Now.Millisecond);

            Assert.AreEqual(BinaryGap.solution(1041), 5);
            Assert.AreEqual(BinaryGap.solution(12343), 6);
        }
    }

}
