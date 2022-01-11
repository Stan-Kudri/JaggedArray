using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти сумму всех отрицательных элементов массива
    public class Task3
    {
        private readonly int[][] _array;

        public Task3(int [][] array)
        {
            _array = array;
        }

        public int SumNegativeElements() => _array.SelectMany(x => x).Where(p => p < 0).Sum();
    }
}
