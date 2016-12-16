using Codility.Arrays;
using Codility.Iterations;
using Codility.PrefixSums;
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

            Random rnd = new Random((int)DateTime.Now.Ticks);


            int[] at = Enumerable.Repeat(0, 100000).Select(i2 => rnd.Next(-10000, 10001)).ToArray();
            int t1 = MinAvgTwoSlice.solution(at);
            int t2 = MinAvgTwoSlice.solution1(at);



            Console.Read();
        }
    }
}
