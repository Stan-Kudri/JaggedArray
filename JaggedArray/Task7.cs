using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти первый положительный элемент
    public class Task7
    {
        private readonly int[][] _array;

        public Task7(int[][] array) => _array = array;

        public int? FirstPositiveElement()
        {
            for(var i=0; i < _array.Length; i++)
            {
                for(var j=0; j < _array[i].Length; j++)
                {
                    if(_array[i][j] > 0)
                    {
                        return _array[i][j];
                    }
                }
            }
            return null;
        }
    }
}
