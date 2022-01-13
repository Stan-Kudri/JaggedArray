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
            var result = _array.SelectMany(x => x).Where(x => x < 0);
            foreach(var value in result)
            {
                return value;
            }
            return null;
            /*int? result = _array.SelectMany(x => x).Cast<int?>().FirstOrDefault(x => x < 0);
            return result;
            int? result = _array.SelectMany(x => x).FirstOrDefault(x => x < 0 , ) ;
            return result < 0 ? result : null;
            foreach(var item in _array)
            {
                foreach (var element in item)
                {
                    if (element < 0)
                    {
                        return element;
                    }
                }
            }
            return null;
            */
        }
    }
}
