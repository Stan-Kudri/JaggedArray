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

        public int? NumberPositiveElements()
        {
            var numberElements = 0;
            foreach(var item in _array)
            {
                foreach(var element in item)
                {
                    if(element > 0)
                    {
                        numberElements++;
                    }
                }
            }
            return numberElements;
        }
    }
}
