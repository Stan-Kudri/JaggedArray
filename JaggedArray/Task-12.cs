using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти максимальный элемент массива
    internal class Task_12
    {
        private readonly int[][] _array;

        public Task_12(int[][] array) => _array = array;

        public int MaxElement()
        {
            var maxValue = int.MinValue;
            var minValue = int.MaxValue;
            for (var i = 0; i < _array.Length; i++)
            {
                for (var j = 0; j < _array[i].Length; j++)
                {
                    if (_array[i][j] > maxValue) maxValue = _array[i][j];
                    if (_array[i][j] < minValue) minValue = _array[i][j];
                }
            }
            return maxValue+minValue;
        }
    }
}
