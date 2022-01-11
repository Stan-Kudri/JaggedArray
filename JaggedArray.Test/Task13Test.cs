using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JaggedArray.Test
{
    public class Task13Test
    {
        [Theory]
        [MemberData(nameof(SortTestData))]
        public void SortTest(int[][] array, int[][] expectArray)
        {
            var task = new Task13(array);

            var sortArray = task.Sort();

            Assert.Equal(expectArray, sortArray);
        }

        public static IEnumerable<object []> SortTestData()
        {
            return new List<object[]>
            {
                new object []
                {
                    new int[][]
                    {
                        new int[] { 1, 3, -4 },
                        new int[] { -2, 6, -3 }
                    },
                    new int[][]
                    {
                        new int[] {-4, 1, 3 },
                        new int[] {-3, -2, 6 }
                    }
                },
                new object []
                {
                    new int[][]
                    {
                        new int[] { 0, 0, 0 },
                        new int[] { 0, 0, 0 }
                    },
                    new int[][]
                    {
                        new int[] {0, 0, 0 },
                        new int[] {0, 0, 0 }
                    }
                },
                new object []
                {
                    new int[][]
                    {
                        new int[] { 1, 3 },
                        new int[] { 2, 6 }
                    },
                    new int[][]
                    {
                        new int[] {1, 3 },
                        new int[] {2, 6 }
                    }
                },
                new object []
                {
                    new int[][]
                    {
                        
                    },
                    new int[][]
                    {
                        
                    }
                },
                new object []
                {
                    new int[][]
                    {
                        new int[] { },
                        new int[] { }
                    },
                    new int[][]
                    {
                        new int[] { },
                        new int[] { }
                    }
                }
            };
        }
    }
}
