using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти максимальный элемент массива
    public class Task10
    {
        private readonly int[][] _array;

        public Task10(int [][] array) => _array = array;

        public int? MaxElement()
        {
            var maxValue = int.MinValue;
            for(var i=0; i < _array.Length; i++)
            {
                for (var j = 0; j < _array[i].Length; j++)
                {
                    if (_array[i][j] > maxValue)
                    {
                        maxValue = _array[i][j];
                    }
                }
            }
            if(maxValue != int.MinValue)
                return maxValue;
            return null;
        }
    }
}
