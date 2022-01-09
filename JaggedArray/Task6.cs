using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти первый отрицательный элемент
    public class Task6
    {
        private readonly int[][] _array;

        public Task6(int[][] array) => _array = array;

        public int? FirstNegativeElement()
        {
            foreach(var item in _array)
            {
                foreach (var element in item)
                    if (element < 0)
                    {
                        return element;
                    }
            }
            return null;
        }
    }
}
