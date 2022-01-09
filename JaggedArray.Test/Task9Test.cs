using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JaggedArray.Test
{
    public class Task9Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void SumNotEvenElementsTest(int[][] array, int? expectSum)
        {
            var task = new Task9(array);

            var sum = task.SumNotEvenElements();

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
                        new int[]{1, 2},
                        new int[]{3, 4}
                    },4
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, -3,},
                        new int[] { 3, 4,}
                    },1
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 2, 4,},
                        new int[] { 12, 6,}
                    },0
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
