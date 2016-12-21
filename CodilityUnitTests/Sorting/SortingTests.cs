using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Sorting;

namespace CodilityUnitTests.PrefixSums
{
    [TestClass]
    public class Sorting
    {
        [TestMethod]
        public void NumberOfDiscIntersectionsTest()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
         
            for(int i = 0; i < 1000; i++)
            {
                int[] at = Enumerable.Repeat(0, rnd.Next(0, 1000)).Select(i2 => rnd.Next(0, int.MaxValue)).ToArray();
                //int t1 = NumberOfDiscIntersections.solution(at);
                //int t2 = NumberOfDiscIntersections.solution1(at);
                //Assert.AreEqual(t1, t2, 0, $"Result: [ex:{t2} ,go: {t1}]");
            }
        }

    }

}
