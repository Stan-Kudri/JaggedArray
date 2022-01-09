using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Отсортировать зубья пузырьковым методом зубчатого массива
    public class Task13
    {
        private readonly int[][] _array;

        public Task13(int [][] array)
        {
            _array = array;
        }

        private void Swap(int[] array, int j, int k)
        {
            var number = array[k];
            array[k] = array[j];
            array[j] = number;
        }

        public int[][] BubbleTeethSort()
        {
            var sortedArray = _array;            
            for(var i = 0; i < sortedArray.Length; i++)
            {
                for (var j = 0; j < sortedArray[i].Length; j++)
                {
                    for(var k = j+1; k < sortedArray[i].Length; k++)
                    {
                        if(sortedArray[i][j] > sortedArray[i][k])
                        {
                            Swap(sortedArray[i], j, k);
                        }
                    }
                }
            }
            return sortedArray;
        }
    }
}
