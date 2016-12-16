using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Codility.Challenges.WinterLights;

namespace CodilityUnitTests.Challenges
{
    [TestClass]
    public class WinterLights
    {

        [TestMethod]
        public void solutionTest()
        {
            Assert.AreEqual(solution("02002"),11);
        }
    }

}
