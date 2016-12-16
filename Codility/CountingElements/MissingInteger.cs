using System.Collections.Generic;
using static System.Console;

namespace Codility.CountingElements
{
    public class MissingInteger
    {
        //100% Coudn't figure it out by myself, this is correct solution but i have my doubs, as there might be values not starting form 1 imo
        public static int solution(int[] A)
        {
            bool[] results = new bool[A.Length + 1];

            for (int i = 0; i < A.Length; i++)
                if (A[i] > 0 && A[i] <= A.Length)
                    results[A[i] - 1] = true;

            for (int i = 0; i < results.Length; i++)
                if (!results[i])
                    return (i + 1);

            return 1;
        }

        //100% / 25% = (66%)
        public static int solution1(int[] A)
        {
            int min = 1;

            for (int i = 0; i < A.Length; i++)
                if (A[i] == min)
                {
                    ++min;
                    i = 0;
                }

            return min;
        }
    }
}

/*Write a function:

class Solution { public int solution(int[] A); }

that, given a non-empty zero-indexed array A of N integers, returns the minimal positive integer (greater than 0) that does not occur in A.

For example, given:

  A[0] = 1
  A[1] = 3
  A[2] = 6
  A[3] = 4
  A[4] = 1
  A[5] = 2
the function should return 5.

Assume that:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.*/
