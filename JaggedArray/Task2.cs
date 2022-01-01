using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти сумму всех положительных элементов массива
    public class Task2
    {
        private readonly int[][] _array;

        public Task2(int[][] array)
        {
            _array = array;
        }

        public int SumPositiveElements()
        {
            var summ = 0;
            foreach (var item in _array)
            {
                foreach (var element in item)
                {
                    if (element > 0)
                    {
                        summ += element;
                    }
                }
            }
            return summ;
        }
    }
}
