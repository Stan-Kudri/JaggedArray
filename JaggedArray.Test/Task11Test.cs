using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JaggedArray.Test
{
    public class Task11Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void MinElementTest(int[][] array, int? expectNumber)
        {
            var task = new Task11(array);

            var value = task.MinElement();

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
                    new int[] { 1, 2},
                    new int[] { 3, 4}
                    },1
                },
                new object[]
                {
                    new int[][]
                    {
                    new int[] { -1, 2},
                    new int[] { 3, -4}
                    },-4
                },
                new object[]
                {
                    new int[][]
                    {
                    new int[] { 0, 0},
                    new int[] { 0, 0}
                    },0
                },
                new object[]
                {
                    new int[][]
                    {

                    },null
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { },
                        new int[] { }
                    },null
                }
            };
        }
    }
}
