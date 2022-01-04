using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти сумму четных элементов
    internal class Task_8
    {
        private readonly int[][] _array;

        public Task_8(int [][] array) => _array = array;

        public int SummEvenElements()
        {
            var summ = 0;
            foreach(var item in _array)
            {
                foreach (var element in item.Where(element => element % 2 == 0))
                {
                    summ += element;
                }
            }
            return summ;
        }
    }
}
