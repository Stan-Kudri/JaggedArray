using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JaggedArray.Test
{
    public class Task12Test
    {
        [Theory]
        [MemberData(nameof(HasElementsTestData))]
        public void HasElementsTest(int[][] array, int? expectMaxNumber, int? expectMinNumber)
        {
            var task = new Task12(array);

            var valueMaxAndMin = task.MaxAndMinElement();

            Assert.Equal(expectMaxNumber, valueMaxAndMin.MaxValue);
            Assert.Equal(expectMinNumber, valueMaxAndMin.MinValue);
        }

        public static IEnumerable<object[]> HasElementsTestData()
        {
            return new List<object[]>
            {
                new object[]
                {
                    new int[][]
                    {
                        new int [] { 1, 2, 3 },
                        new int [] { 4, 5 }
                    },5,1
                },
                new object[]
                {
                    new int[][]
                    {
                        new int [] { -1, 2, 3 },
                        new int [] { 4, -5 }
                    },4,-5
                },
                new object[]
                {
                    new int[][]
                    {
                        new int [] { 1, 1, 1 },
                        new int [] { 1, 1 }
                    },1,1
                },
                new object[]
                {
                    new int[][]
                    {
                        new int [] { 1 },
                        new int [] { -1 }
                    },1,-1
                },
                new object[]
                {
                    new int[][]
                    {
                        new int [] { 1 },
                    },1,1
                }
            };
        }

        [Theory]
        [MemberData(nameof(HasNoElementsTestData))]
        public void HasNoElementsTest(int[][] array, Task12.MaxAndMinValue expectClass)
        {
            var task = new Task12(array);

            var valueMaxAndMin = task.MaxAndMinElement();

            Assert.Equal(expectClass, valueMaxAndMin);
        }
        public static IEnumerable<object[]> HasNoElementsTestData()
        {
            return new List<object[]>
            {
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
