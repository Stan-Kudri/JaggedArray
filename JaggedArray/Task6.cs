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
            foreach(var value in _array.SelectMany(x => x).Where(x => x < 0))
                return value;
            return null;
        }
    }
}
