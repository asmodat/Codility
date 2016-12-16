using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Iterations;

namespace CodilityUnitTests.Iterations
{
    [TestClass]
    public class Iterations
    {

        [TestMethod]
        public void BinaryGapTest()
        {
            Console.WriteLine("Start");

           // Random r = new Random(DateTime.Now.Millisecond);

            Assert.AreEqual(BinaryGap.solution(1041), 5);
            Assert.AreEqual(BinaryGap.solution(12343), 6);
        }
    }

}
