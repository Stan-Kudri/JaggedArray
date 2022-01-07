using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти количество отрицательных элементов массива
    internal class Task_5
    {
        private readonly int[][] _array;

        public Task_5(int[][] array)
        {
            _array = array;
        }

        public int? NumberNegativeElements()
        {
            var numberElements = 0;
            foreach (var item in _array)
            {
                foreach(var element in item)
                {
                    if (element < 0)
                    {
                        numberElements++;
                    }
                }
            }
            return numberElements;
        }
    }
}
