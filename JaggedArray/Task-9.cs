using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти сумму нечетных элементов
    internal class Task_9
    {
        private readonly int[][] _array;

        public Task_9(int[][] array) => _array = array;

        public int SummEvenElements()
        {
            var summ = 0;
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
