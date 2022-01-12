using System.Collections.Generic;
using Xunit;

namespace JaggedArray.Test
{
    public class Task2Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void SumPositiveTest(int[][] array, int expectSum)
        {
            var task = new Task2(array);

            var sum = task.SumPositiveElements();

            Assert.Equal(expectSum, sum);
        }

        public static IEnumerable<object[]> TestData()
        {
            return new List<object[]>
            {
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, 2, 3 },
                        new int[] { 4, 5, 6 }
                    },
                    21
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, 2, 3 },
                        new int[] { 4, 5, 6 }
                    },
                    21
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, 2, 3 },
                        new int[] { 4, 5, 6 }
                    },
                    21
                },
                new object[]
                {
                    new int[][]
                    {

                    },
                    null
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[]{ },
                        new int[]{ }
                    },null
                }
            };
        }
    }
}