using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти количество отрицательных элементов массива
    public class Task5
    {
        private readonly int[][] _array;

        public Task5(int[][] array)
        {
            _array = array;
        }

        public int? NumberNegativeElements() => _array.Select(x => x.Count(y => y < 0)).Sum();
    }
}
