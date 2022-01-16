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
            if (!_array.HasElement())
                return null;
            return _array.SelectMany(x => x).Max(x => x);
        }
    }
}
