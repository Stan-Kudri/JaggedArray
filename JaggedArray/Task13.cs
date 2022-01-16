using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Отсортировать все строки массива
    public class Task13
    {
        private readonly int[][] _array;

        public Task13(int [][] array)
        {
            _array = array;
        }
        
        public int[][]? Sort()
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
            var newSortArray = new int[_array.Length][];
            for(var i = 0; i < newSortArray.Length; i++)
            {
                newSortArray[i] = (int[]) sortedArray[i].Clone();
            }
            return newSortArray;
        }

        private void Swap(int[] array, int j, int k)
        {
            var number = array[k];
            array[k] = array[j];
            array[j] = number;
        }

    }
}
