using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти количество положительных элементов массива
    public class Task4
    {
        private readonly int[][] _array;

        public Task4(int[][] array)
        {
            _array = array;
        }

        public int? NumberPositiveElements() => _array.SelectMany(x => x).Where(y => y > 0).Count();
    }
}
