using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Iterations;
using Codility.Arrays;

namespace CodilityUnitTests.Arrays
{
    [TestClass]
    public class Iterations
    {

        [TestMethod]
        public void CyclicRotationTest()
        {
            Console.WriteLine("Start");

            // Random r = new Random(DateTime.Now.Millisecond);

            CollectionAssert.AreEqual(CyclicRotations.solution(new int[] { 3,8,9,7,6}, 3), new int[] { 9, 7, 6, 3, 8 });
        }

        [TestMethod]
        public void OddOccurrencesInArrayTest()
        {
            Console.WriteLine("Start");

            // Random r = new Random(DateTime.Now.Millisecond);

            Assert.AreEqual(OddOccurrencesInArray.solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }), 7);
        }
    }

}
