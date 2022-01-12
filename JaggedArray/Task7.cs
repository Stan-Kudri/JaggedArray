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
            int? result = _array.SelectMany(x => x).Cast<int?>().FirstOrDefault(x => x > 0);
            return result;
        }
    }
}
