using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти сумму всех элементов массива
    public class Task1
    {
        private readonly int[][] _array;
        
        public Task1(int[][] array)
        {
            _array = array;
        }

        public int Sum()
        {
            var sum = 0;
            foreach(var item in _array)
            {
                sum += item.Sum();
            }
            return sum;
        }        
    }
}
