using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_algorithms
{
    internal class Jump
    {
        public static int Jump(int[] subjectArray, int target) { 
            int n = subjectArray.Length;
            double step = Math.Sqrt(n);
            int prev = 0;

            while (subjectArray[Math.Min((int)Math.Round(step), n) - 1] < target)
            {
                prev = (int)step;
                step += Math.Sqrt(n);
                if (prev >= n)
                {
                    return -1;
                }
            }

            while (subjectArray[prev] < target)
            {
                prev++;
                if (prev == Math.Min(step, n))
                {
                    return -1;
                }
            }

            if (subjectArray[prev] == target)
            {
                return prev;
            }
            else
            {
                return -1;
            }
        }
    }
}

// it was the hard one for me, until now :)
