using System.Collections.Generic;
using Xunit;

namespace JaggedArray.Test
{
    public class Task1Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void SumTest(int [][] array, int expectSum)
        {
            var task = new Task1(array);

            var sum = task.Sum();

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
                        new int[] { 2, 4, 6 },
                        new int[] { 3, 4, 5 }
                    },30
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, -2, 3 },
                        new int[] { -2, 4, -6 }
                    },-2
                },
                new object[]
                {
                    new int[][]
                    {

                    },null
                }
            };
        }
    }
}