using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Codility.Arrays
{
    public class OddOccurrencesInArray
    {
        //100% / 100%
        public static int solution(int[] A)
        {
            //xoring with the same number should give zero
            int xor = 0;

            for (int i = 0; i < A.Length; i++)
                xor ^= A[i];

            return xor;
        }


        //100% / 66% 
        public static int solution1(int[] A)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (list.Contains(A[i]))
                    list.Remove(A[i]);
                else
                    list.Add(A[i]);
            }

            return list[0];
        }

        //100% / 50%, (77%)
        public static int solution2(int[] A)
        {
            int[] results = new int[1000001];

            for (int i = 0; i < A.Length; i++)
                ++results[A[i]];

            for (int i = 0; i < results.Length; i++)
                if (results[i] % 2 != 0)
                    return i;

            return -1;
        }
    }
}

/*A non-empty zero-indexed array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.

For example, in array A such that:

  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
the elements at indexes 0 and 2 have value 9,
the elements at indexes 1 and 3 have value 3,
the elements at indexes 4 and 6 have value 9,
the element at index 5 has value 7 and is unpaired.
Write a function:

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.

For example, given array A such that:

  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9
the function should return 7, as explained in the example above.

Assume that:

N is an odd integer within the range [1..1,000,000];
each element of array A is an integer within the range [1..1,000,000,000];
all but one of the values in A occur an even number of times.
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(1), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.*/


/*
100% / 66%
List<int> list = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (list.Contains(A[i]))
                    list.Remove(A[i]);
                else
                    list.Add(A[i]);
            }

            return list[0];

 */
