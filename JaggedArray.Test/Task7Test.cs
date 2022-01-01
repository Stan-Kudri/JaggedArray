using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JaggedArray.Test
{
    public class Task7Test
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void FirstPositiveElementTest(int[][] array, int? expectNumber)
        {
        var task = new Task7(array);

        var value = task.FirstPositiveElement();

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
                        new int [] { 1, 2 },
                        new int [] { 3, 4 }
                    },1
                },
                new object[]
                {
                    new int[][]
                    {
                        new int [] { -1, -2 },
                        new int [] { -3, -4 }
                    },null
                },
                new object[]
                {
                    new int[][]
                    {
                      
                    },null
                },
            };
        }
    }
}
