﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace Codility.StacksAndQueues
{
    public class Brackets
    {
        //100%
        public static int solution(string S)
        {
            if (S == null || S.Length <= 0)
                return 1;

            int l = S.Length, i = 0;
            char c;
            List<char> scores = new List<char>();

            for (; i < l; i++)
            {
                c = S[i];

                if (c == ')' || c == '}' || c == ']')
                {
                    if (scores.Count <= 0)
                        return 0;

                    if(Math.Abs(c - scores[scores.Count - 1]) > 2) //check assci table for proof xD
                        return 0;

                    scores.RemoveAt(scores.Count - 1);
                }
                else
                    scores.Add(c);
            }

            return scores.Count == 0 ? 1 : 0;
        }
    }
}



/*
A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

S is empty;
S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
S has the form "VW" where V and W are properly nested strings.
For example, the string "{[()()]}" is properly nested but "([)()]" is not.

Write a function:

class Solution { public int solution(string S); }

that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

Assume that:

N is an integer within the range [0..200,000];
string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N) (not counting the storage required for input arguments).
Copyright 2009–2017 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
     */



