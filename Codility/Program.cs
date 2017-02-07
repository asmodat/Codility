using Codility.Arrays;
using Codility.Iterations;
using Codility.PrefixSums;
using Codility.Sorting;
using Codility.StacksAndQueues;
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

            StoneWall.solution(new int[] {8,8,5,7,9,8,7,4,5 });
            StoneWall.solution(new int[] { 3,2,1 });
            StoneWall.solution(new int[] { 1,2,3,3,2,1 });

            Console.Read();
        }
    }
}
