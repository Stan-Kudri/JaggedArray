using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти сумму четных элементов
    public class Task8
    {
        private readonly int[][] _array;

        public Task8(int [][] array) => _array = array;

        public int? SumEvenElements()
        {
            if (!_array.HasElement())
                return null;
            return _array.SelectMany(x => x).Where(x => x % 2 == 0).Sum();
        }
    }
}
