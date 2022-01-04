using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Отсортировать зубья пузырьковым методом зубчатого массива
    internal class Task_13
    {
        private readonly int[][] _array;

        public Task_13(int [][] array)
        {
            _array = array;
        }

        public int[][] BubbleTeethSort()
        {
            var sortedArray = _array;            
            for(var i = 0; i < sortedArray.Length; i++)
            {
                int number;
                for (var j = 0; j < sortedArray[i].Length; j++)
                {
                    for(var k = j+1; k < sortedArray[i].Length; k++)
                    {
                        if(sortedArray[i][j] > sortedArray[i][k])
                        {
                            number = sortedArray[i][k];
                            sortedArray[i][k] = sortedArray[i][j];
                            sortedArray[i][j] = number;
                        }
                    }
                }
            }
            return sortedArray;
        }
    }
}
