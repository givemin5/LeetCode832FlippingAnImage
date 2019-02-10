using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode832FlippingAnImage
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i].Reverse().Select(x => Not(x)).ToArray();
            }

            return A;
        }

        private int Not(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
