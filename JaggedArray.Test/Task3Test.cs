using System.Collections.Generic;
using Xunit;

namespace JaggedArray.Test
{
    public class Task3Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void SumNegativeTest(int [][] array, int expectSum)
        {
            var task = new Task3(array);

            var sum = task.SumNegativeElements();

            Assert.Equal(expectSum, sum);
        }

        public static IEnumerable<object[]> TestData()
        {
            return new List<object[]>
            {
                new object[]
                {
                    new int [][]
                    {
                        new int [] { 1, 2 },
                        new int [] { 3, 4 }
                    },0
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
                        new int [] { -1, 2 },
                        new int [] { -3, -4 }
                    },-8
                },
                new object[]
                {
                    new int [][]
                    {
                        new int [] { -1, 2 },
                        new int [] { 3, -4 }
                    },-5
                },
            };
        }
        
    }
}
