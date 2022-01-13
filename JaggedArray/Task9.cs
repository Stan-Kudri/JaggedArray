using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти сумму нечетных элементов
    public class Task9
    {
        private readonly int[][] _array;

        public Task9(int[][] array) => _array = array;

        public int? SumNotEvenElements()
        {
            var sum = 0;
            if (!Extension.HasElement(_array))
            {
                return null;
            }
            sum += _array.SelectMany(x => x).Where( x => x%2 != 0).Sum();            
            return sum;
        }
    }
}
