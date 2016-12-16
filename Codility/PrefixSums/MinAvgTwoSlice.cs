using static System.Console;

namespace Codility.PrefixSums
{
    public class MinAvgTwoSlice
    {
        //O(N) 100%
        public static int solution(int[] A)
        {
            int i, i2 = 0, n = 0, sum = 0, idx = 0, l = A.Length;
            double min = int.MaxValue, avgNow, avgPrev = 0;// = int.MaxValue;
      
            for (i = 0; i < l - 1; i++)
            {
                sum = A[i];
                avgPrev = int.MaxValue;

                for (i2 = (i + 1); i2 < l && i2 < i + 3; i2++)
                {
                    n = (i2 - i) + 1;
                    sum += A[i2];
                    avgNow = (double)sum / n;

                    if (avgNow > avgPrev)
                    {
                        avgPrev = avgNow;
                        break;
                    }
                    else
                        avgPrev = avgNow;

                    if (avgNow < min)
                    {
                        min = avgNow;
                        idx = i;
                    }
                }
            }

            return idx;
        }
        /* <-- explanation
         This is a mathematical problem... and you have to understand the relationship
that exists between the averages of the slices.

We know from the problem description that the slices are a minimum length of 2. 
The trick to this problem is that the min average slice also cannot be longer than 3.
So we only have to calculate the avg of the slices of length 2 and 3.

To understand why the min average slice cannot be longer than 3, consider
the case where it is longer than 3...

ex. [-10, 3, 4, -20]

avg(0,3) = -23 / 4 = -5.75 // entire array is -5.75 average
avg(0,1) = -7 / 2 = -3.5 // subslice (0,1)
avg(2,3) = -16 / 2 = -8 // subslice (2,3)

Notice that (avg(0,1) + avg(2,3)) / 2 = avg(0,3)
Therefore, if avg(0,1) != avg(2,3) then one of them must be smaller than the other.

No matter which way we split up this array, if the slices aren't exactly the same,
then one of them must have a lower average than the full slice. Play around with it
and you'll see that it's true. There are mathematical proofs out there for this.
             */


        //O(N) or O(N^2) - way faster, 100%, 60% = 80% <-- I did came up with this solution but not the one above that limits the length of the slice form 2 to 3 elements max...
        public static int solution2(int[] A)
        {
            int i, i2, n, sum, idx = 0, l = A.Length;
            double min = int.MaxValue, avgNow, avgPrev;

            for (i = 0; i < l - 1; i++)
            {
                sum = A[i];
                avgPrev = int.MaxValue;
                for (i2 = (i + 1); i2 < l; i2++)
                {
                    n = (i2 - i) + 1;
                    sum += A[i2];
                    avgNow = (double)sum / n;

                    if (avgNow > avgPrev)
                        break;
                    else
                        avgPrev = avgNow;

                    if (avgNow < min)
                    {
                        min = avgNow;
                        idx = i;
                    }
                }
            }

            return idx;
        }

        //O(N^2), pass, 100%/20%
        public static int solution1(int[] A)
        {
            int i,i2,n, sum, idx = 0, l = A.Length;
            double avg = int.MaxValue, min = int.MaxValue;

            for (i = 0; i < l - 1; i++)
            {
                sum = A[i];
                for (i2 = (i + 1); i2 < l; i2++)
                {
                    n = (i2 - i) + 1;
                    sum += A[i2];
                    avg = (double)sum / n;
                    if(avg < min)
                    {
                        min = avg;
                        idx = i;
                    }
                }
            }

            return idx;
        }

        
        
    }
}

/*
A non-empty zero-indexed array A consisting of N integers is given. A pair of integers (P, Q), such that 0 ≤ P < Q < N, is called a slice of array A (notice that the slice contains at least two elements). The average of a slice (P, Q) is the sum of A[P] + A[P + 1] + ... + A[Q] divided by the length of the slice. To be precise, the average equals (A[P] + A[P + 1] + ... + A[Q]) / (Q − P + 1).

For example, array A such that:

    A[0] = 4
    A[1] = 2
    A[2] = 2
    A[3] = 5
    A[4] = 1
    A[5] = 5
    A[6] = 8
contains the following example slices:

slice (1, 2), whose average is (2 + 2) / 2 = 2;
slice (3, 4), whose average is (5 + 1) / 2 = 3;
slice (1, 4), whose average is (2 + 2 + 5 + 1) / 4 = 2.5.
The goal is to find the starting position of a slice whose average is minimal.

Write a function:

class Solution { public int solution(int[] A); }

that, given a non-empty zero-indexed array A consisting of N integers, returns the starting position of the slice with the minimal average. If there is more than one slice with a minimal average, you should return the smallest starting position of such a slice.

For example, given array A such that:

    A[0] = 4
    A[1] = 2
    A[2] = 2
    A[3] = 5
    A[4] = 1
    A[5] = 5
    A[6] = 8
the function should return 1, as explained above.

Assume that:

N is an integer within the range [2..100,000];
each element of array A is an integer within the range [−10,000..10,000].
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.
     */
