using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode832FlippingAnImage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[][] A = new int[][]
            {
                new int[]{1, 1, 0},
                new int[]{1, 0, 1},
                new int[]{0, 0, 0}
            };

            Solution solution = new Solution();

            var actual = solution.FlipAndInvertImage(A);

            var expected = new int[][]
            {
                new int[]{1, 0, 0},
                new int[]{0, 1, 0},
                new int[]{1, 1, 1}
            };
            for (int i = 0; i < actual.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i],actual[i]);
            }

            //CollectionAssert.AreEqual(expected,actual);
            //Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
