using System;
using System.Collections.Generic;
using static System.Console;

//https://codility.com/c/feedback/VV6Q2B-UUG

namespace Codility.Tests
{
    public class Flextrade
    {
        public static string solution1(string S)
        {
            string sBuffor = string.Empty, sResult = string.Empty;
            sBuffor = S.Replace("-", "");
            sBuffor = S.Replace(" ", "");

            for(int i = 1; i <= S.Length; i++)
            {
                sResult += sBuffor[i - 1];
                if (i % 3 == 0 && i < S.Length)
                    sResult += "-";
            }

            return sResult;
        }
        public static int solution2(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M + 1];

            for (int i = 0; i <= M; i++)
                count[i] = 0;

            int maxOccurence = 1;
            int index = -1;
            for (int i = 0; i < N; i++)
            {
                if (count[A[i]] > 0)
                {
                    int tmp = count[A[i]];
                    if (tmp > maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = i;
                    }
                    count[A[i]] = tmp + 1;
                }
                else
                {
                    count[A[i]] = 1;
                }
            }
            return A[index];
        }

        string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        int[] Days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        string[] Week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public int solution3(int Y, string A, string B, string W)
        {
            int dow = 0, dowStart, dowStop;
            for (int i = 0; i < Week.Length; i++)
                if(Week[i] == W)
                {
                    dow = i + 1;
                    break;
                }

            bool isLeap = Y % 4 == 0 ? true : false;
            int sum = 0;
            bool start = false;


            bool startInstant = true, stopInstant = true;
            int days = 0;
            for (int i = 0; i < Months.Length; i++)
            {
                days = (isLeap && Months[i] == "February") ? 29 : Days[i];

                dowStart = dow;

                for (int i2 = 0; i2 < days; i2++)
                    dow = dow == 7 ? 1 : dow + 1;

                dowStop = dow;


                if (start || Months[i] == A)
                {
                    start = true;
                    if (dowStart > 1)
                        startInstant = false;
                }
                else
                    continue;


                days += sum;

                if (Months[i] == B)
                {
                    if (dowStop < 7)
                        stopInstant = false;
                    break;
                }
            }

            int result = sum / 7;
            if (!startInstant)
                --result;
            if (!stopInstant)
                --result;

            return result;
        }
        public static int solution4(int n)
        {
            int[] d = new int[30];
            int l = 0;
            int p;
            while (n > 0)
            {
                d[l] = n % 2;
                n /= 2;
                l++;
            }
            for (p = 1; p < 1 + l; ++p)
            {
                int i;
                bool ok = true;
                for (i = 0; i < l - p; ++i)
                {
                    if (d[i] != d[i + p])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    return p;
                }
            }
            return -1;
        }

    }
}

/**/
/**/
/**/
/**/
