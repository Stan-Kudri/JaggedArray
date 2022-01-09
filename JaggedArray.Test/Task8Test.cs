using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JaggedArray.Test
{
    public class Task8Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void SumEvenElementsTest(int[][] array, int? expectSum)
        {
        var task = new Task8(array);

        var sum = task.SumEvenElements();

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
                        new int[] { 1, 2,},
                        new int[] { 3, 4,}
                    },6
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, -2,},
                        new int[] { 3, 4,}
                    },2
                },
                new object[]
                {
                    new int[][]
                    {
                        new int[] { 1, 3,},
                        new int[] { 3, 5,}
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
