using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JaggedArray.Test
{
    public class Task10Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void MaxElementTest(int[][] array, int? expectNumber)
        {
            var task = new Task10(array);

            var value = task.MaxElement();

            Assert.Equal(expectNumber, value);
        }

        public static IEnumerable<object[]> TestData()
        {
            return new List<object[]>
            {
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, 3 },
                        new int[] { 2, -4 }
                    }, 3
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { -1, -3 },
                        new int[] { -2, -4 }
                    }, -1
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 0, 0 },
                        new int[] { 0, 0 }
                    }, 0
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { },
                        new int[] { }
                    },null
                },
                new object[]
                {
                    new int[][]
                    {

                    }, null
                }
            };
        }
    }
}
