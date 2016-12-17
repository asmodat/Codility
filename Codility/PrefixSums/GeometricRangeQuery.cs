using static System.Console;

namespace Codility.PrefixSums
{
    public class GeometricRangeQuery
    {
        //O(N) 100% <- this works withouth looking for sum of prefixes like other solutions in O(N) time
        //my idea is to calculate first index of minimum value, before inerating to find other case if the range occures before minimum valie
        public static int[] solution(string S, int[] P, int[] Q)
        {
            int l = P.Length, sl = S.Length, i, i2, next, min;
            int[] idx = new int[sl];
            int[] result = new int[l];

            for (i = 0; i < sl; i++)
            {
                idx[i] = i;
                next = sl - 1;

                for (i2 = i + 1; i2 < sl; i2++)
                    if (S[i2] <= S[idx[i]])
                    {
                        idx[i] = i2;
                        next = i2;
                        if (S[i2] == 'A')
                            break;
                    }
                
                for(i2 = i + 1; i2 <= next; i2++)
                    idx[i2] = idx[i];

                i = next;
            }

            idx[sl - 1] = sl - 1;

            for (i = 0; i < l; i++)
            {
                min = S[P[i]];
                
                if (Q[i] < idx[P[i]])
                    for (i2 = P[i] + 1; i2 <= Q[i]; i2++)
                    {
                        if (S[i2] < min)
                        {
                            min = S[i2];
                            if (min == 'C')
                                break;
                        }
                    }
                else
                    min = S[idx[P[i]]];

                switch (min)
                {
                    case 'A': result[i] = 1; break;
                    case 'C': result[i] = 2; break;
                    case 'G': result[i] = 3; break;
                    default: result[i] = 4; break;
                }
            }

            return result;
        }

        //O(N*M) 100% / 0%
        public static int[] solution2(string S, int[] P, int[] Q)
        {
            int l = P.Length;
            int[] result = new int[l];
            int i, i2;
            char min;
            
            for (i = 0; i < l; i++)
            {
                min = S[P[i]];
                
                for (i2 = P[i] + 1; i2 <= Q[i]; i2++)
                {
                    if (S[i2] < min)
                    {
                        min = S[i2];
                        if (min == 'A')
                            break;
                    }
                }

                switch (min)
                {
                    case 'A': result[i] = 1; break;
                    case 'C': result[i] = 2; break;
                    case 'G': result[i] = 3; break;
                    default: result[i] = 4; break;
                }
            }

            return result;
        }

        //O(N*M) 100% / 33%
        public static int[] solution1(string S, int[] P, int[] Q)
        {
            int[] decoder = new int[S.Length];
            int l = P.Length;
            int[] result = new int[l];
            int min, i, i2;

            for (i = 0; i < decoder.Length; i++)
                switch (S[i])
                {
                    case 'A': decoder[i] = 1; break;
                    case 'C': decoder[i] = 2; break;
                    case 'G': decoder[i] = 3; break;
                    default: decoder[i] = 4; break;
                }


            for(i = 0; i < l; i++)
            {
                min = 4;

                for(i2 = P[i]; i2 <= Q[i]; i2++)
                    if(decoder[i2] < min)
                    {
                        min = decoder[i2];
                        if (min == 1)
                            break;
                    }

                result[i] = min;
            }

            return result;
        }

    
        
    }
}

/*
 public static int[] solution(string S, int[] P, int[] Q)
        {
            int l = P.Length, sl = S.Length, i, i2, val, next, min;
            int[] idx = new int[sl];
            int[] result = new int[l];

            for (i = 0; i < sl; i++)
            {
                val = S[i];
                idx[i] = i;
                next = sl - 1;

                for (i2 = i + 1; i2 < sl; i2++)
                    if (S[i2] < S[idx[i]])
                    {
                        idx[i] = i2;
                        next = i2;
                        if (S[i2] == 'A')
                            break;
                    }
                
                for(i2 = i + 1; i2 <= next; i2++)
                    idx[i2] = idx[i];

                i = next;
            }

            for (i = 0; i < l; i++)
            {
                min = S[P[i]];

                //------------------------
                if (Q[i] > idx[P[i]])
                    for (i2 = idx[P[i]] + 1; i2 <= Q[i]; i2++)
                    {
                        if (S[i2] < min)
                        {
                            min = S[i2];
                            if (min == 'C')
                                break;
                        }
                    }
                else
                    min = S[idx[P[i]]];

                    //------------------------------

                switch (min)
                {
                    case 'A': result[i] = 1; break;
                    case 'C': result[i] = 2; break;
                    case 'G': result[i] = 3; break;
                    default: result[i] = 4; break;
                }
            }

            return result;
        }
     */

/*
A DNA sequence can be represented as a string consisting of the letters A, C, G and T, which correspond to the types of successive nucleotides in the sequence. Each nucleotide has an impact factor, which is an integer. Nucleotides of types A, C, G and T have impact factors of 1, 2, 3 and 4, respectively. You are going to answer several queries of the form: What is the minimal impact factor of nucleotides contained in a particular part of the given DNA sequence?

The DNA sequence is given as a non-empty string S = S[0]S[1]...S[N-1] consisting of N characters. There are M queries, which are given in non-empty arrays P and Q, each consisting of M integers. The K-th query (0 ≤ K < M) requires you to find the minimal impact factor of nucleotides contained in the DNA sequence between positions P[K] and Q[K] (inclusive).

For example, consider string S = CAGCCTA and arrays P, Q such that:

    P[0] = 2    Q[0] = 4
    P[1] = 5    Q[1] = 5
    P[2] = 0    Q[2] = 6
The answers to these M = 3 queries are as follows:

The part of the DNA between positions 2 and 4 contains nucleotides G and C (twice), whose impact factors are 3 and 2 respectively, so the answer is 2.
The part between positions 5 and 5 contains a single nucleotide T, whose impact factor is 4, so the answer is 4.
The part between positions 0 and 6 (the whole string) contains all nucleotides, in particular nucleotide A whose impact factor is 1, so the answer is 1.
Write a function:

class Solution { public int[] solution(string S, int[] P, int[] Q); }

that, given a non-empty zero-indexed string S consisting of N characters and two non-empty zero-indexed arrays P and Q consisting of M integers, returns an array consisting of M integers specifying the consecutive answers to all queries.

The sequence should be returned as:

a Results structure (in C), or
a vector of integers (in C++), or
a Results record (in Pascal), or
an array of integers (in any other programming language).
For example, given the string S = CAGCCTA and arrays P, Q such that:

    P[0] = 2    Q[0] = 4
    P[1] = 5    Q[1] = 5
    P[2] = 0    Q[2] = 6
the function should return the values [2, 4, 1], as explained above.

Assume that:

N is an integer within the range [1..100,000];
M is an integer within the range [1..50,000];
each element of arrays P, Q is an integer within the range [0..N − 1];
P[K] ≤ Q[K], where 0 ≤ K < M;
string S consists only of upper-case English letters A, C, G, T.
Complexity:

expected worst-case time complexity is O(N+M);
expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.
     */
