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
            var summ = 0;
            if (_array.Count() == 0)
                return null;
            foreach (var item in _array)
            {
                foreach (var element in item)
                {
                    if (element % 2 != 0)
                    {
                        summ += element;
                    }
                }
            }
            return summ;
        }
    }
}
