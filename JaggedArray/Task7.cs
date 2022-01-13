using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти первый положительный элемент
    public class Task7
    {
        private readonly int[][] _array;

        public Task7(int[][] array) => _array = array;

        public int? FirstPositiveElement()
        {
            var result = _array.SelectMany(x => x).Where(x => x > 0);
            foreach (var value in result)
            {
                return value;
            }
            return null;
        }
    }
}
