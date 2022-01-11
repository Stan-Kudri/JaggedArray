using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти минимальный элемент массива
    public class Task11
    {
        private readonly int[][] _array;

        public Task11(int[][] array) => _array = array;

        public int? MinElement()
        {
            if (!_array.HasElement())
                return null;
            return _array.SelectMany(x => x).Min(x => x);
        }
    }
}
