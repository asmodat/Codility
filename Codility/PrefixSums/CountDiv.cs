using static System.Console;

namespace Codility.PrefixSums
{
    public class CountDiv
    {

        //100% - O(1)
        //return (A % K == 0) ? ((B / K) - (A / K) + 1) : (B / K) - (A / K);
        public static int solution(int A, int B, int K)
        {
            int count;
            int left = A / K;
            int right = B / K;

            count = right - left;

            if (A % K == 0)
                ++count;

            return count;
        }

        //100% - O(N)
        public static int solution1(int A, int B, int K)
        {
            int counter = 0;
            for (int i = A; i <= B; i++)
                if (i % K == 0) ++counter;

            return counter;
        }
        
    }
}

/*
Write a function:

class Solution { public int solution(int A, int B, int K); }

that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:

{ i : A ≤ i ≤ B, i mod K = 0 }

For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.

Assume that:

A and B are integers within the range [0..2,000,000,000];
K is an integer within the range [1..2,000,000,000];
A ≤ B.
Complexity:

expected worst-case time complexity is O(1);
expected worst-case space complexity is O(1).
     */
