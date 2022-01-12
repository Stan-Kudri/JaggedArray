using System.Collections.Generic;
using Xunit;

namespace JaggedArray.Test
{
    public class Task5Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void NumberNegativeElementsTest(int[][] array, int expectNumber)
        {
            var task = new Task5(array);

            var number = task.NumberNegativeElements();

            Assert.Equal(expectNumber, number);

        }

        public static IEnumerable<object[]> TestData()
        {
            return new List<object[]>
            {
                new object[]
                {
                    new int [][]
                    {
                        new int [] { -1, -2, -3 },
                        new int [] { -4, -5, -6 }
                    },6
                },
                new object[]
                {
                    new int [][]
                    {

                    },null
                },
                new object[]
                {
                    new int [][]
                    {
                        new int [] { 1, -2, 3 },
                        new int [] { -4, -5, 6 }
                    },3
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[]{ },
                        new int[]{ }
                    },null
                },
                new object[]
                {
                    new int [][]
                    {
                        new int [] { 0, 0 },
                        new int [] { 0, 0 }
                    },0
                }
            };
        }
    }
}
