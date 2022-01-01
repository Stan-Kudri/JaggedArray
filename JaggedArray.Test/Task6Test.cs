using System.Collections.Generic;
using Xunit;

namespace JaggedArray.Test
{
    public class Task6Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void FirstNegativeElementTest(int[][] array, int? firstNegativNumber)
        {
            var task = new Task6(array);

            var value = task.FirstNegativeElement();

            Assert.Equal(firstNegativNumber, value);
        }

        public static IEnumerable<object[]> TestData()
        {
            return new List<object[]>
            {
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, -2,},
                        new int[] { -3, 4,}
                    },-2
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, 2,},
                        new int[] { 3, 4,}
                    },null
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
