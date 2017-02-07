using System.Collections.Generic;
using static System.Console;

namespace Codility.StacksAndQueues
{
    public class StoneWall
    {
        //100%
        public static int solution(int[] H)
        {
            int tmp = 0, cnt = 0;
            Stack<int> st = new Stack<int>();

            foreach (int h in H)
            {
                while (true)
                    if (h > tmp || st.Count == 0 || st.Peek() < h)
                    {
                        st.Push(h);
                        cnt++;
                        break;
                    }
                    else if (st.Peek() > h) st.Pop();
                    else if (st.Peek() == h) break;

                tmp = h;
            }

            return cnt;
        }

        //100% correctness / 77% preformance / 85% total
        public static int solution2(int[] H)
        {
            int l = H.Length, i = 0, curr, min, prev = 0, cntr = 0;

            min = int.MaxValue;
            bool isEmpty = true;

            for (; i < l; i++)
                try
                {
                    curr = H[i];

                    if (curr <= 0)
                    {
                        min = int.MaxValue;
                        continue;
                    }

                    if (isEmpty && curr != 0)
                    {
                        isEmpty = false;
                        prev = i;
                    }

                    if (curr < min)
                    {
                        min = curr;
                        ++cntr;
                    }

                    H[i] -= min;
                }
                finally
                {
                    if (!isEmpty && i == l - 1)
                    {
                        i = prev;
                        min = int.MaxValue;
                        isEmpty = true;
                    }
                }


            return cntr;
        }


        //100% correctness / 77% preformance / 85% total
        public static int solution1(int[] H)
        {
            int l = H.Length, i = 0, curr, min, cntr = 0;

            min = int.MaxValue;
            bool isEmpty = true;

            for (; i < l; i++)
            {
                curr = H[i];

                if (curr != 0)
                    isEmpty = false;

                if(curr < min)
                {
                    if (curr <= 0)
                    {
                        min = int.MaxValue;

                        if (i == l - 1 && !isEmpty)
                        {
                            i = 0;
                            min = int.MaxValue;
                            isEmpty = true;
                        }

                        continue;
                    }

                    min = curr;
                    ++cntr;
                }

                H[i] -= min;

                if (i == l - 1 && !isEmpty)
                {
                    i = 0;
                    min = int.MaxValue;
                    isEmpty = true;
                }
            }

            return cntr;
        }
    }
}



/*
You are going to build a stone wall. The wall should be straight and N meters long, and its thickness should be constant; however, it should have different heights in different places. The height of the wall is specified by a zero-indexed array H of N positive integers. H[I] is the height of the wall from I to I+1 meters to the right of its left end. In particular, H[0] is the height of the wall's left end and H[N−1] is the height of the wall's right end.

The wall should be built of cuboid stone blocks (that is, all sides of such blocks are rectangular). Your task is to compute the minimum number of blocks needed to build the wall.

Write a function:

class Solution { public int solution(int[] H); }

that, given a zero-indexed array H of N positive integers specifying the height of the wall, returns the minimum number of blocks needed to build it.

For example, given array H containing N = 9 integers:

  H[0] = 8    H[1] = 8    H[2] = 5
  H[3] = 7    H[4] = 9    H[5] = 8
  H[6] = 7    H[7] = 4    H[8] = 8
the function should return 7. The figure shows one possible arrangement of seven blocks.



Assume that:

N is an integer within the range [1..100,000];
each element of array H is an integer within the range [1..1,000,000,000].
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.
     */



