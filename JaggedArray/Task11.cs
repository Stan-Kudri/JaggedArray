using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти минимальный элемент массива
    public class Task11
    {
        private readonly int[][] _array;

        public Task11(int[][] array) => _array = array;

        public int? MinElement()
        {            
            if (!CheckForElement())
            {
                return null;
            }
            var minValue = int.MaxValue;
            foreach(var item in _array)
            {
                foreach (var element in item)
                {
                    if (element < minValue)
                    {
                        minValue = element;
                    }
                }
            }
            return minValue;
        }

        private bool CheckForElement()
        {
            int sum = 0;
            foreach(var item in _array)
            {
                sum += item.Length;
            }
            if(sum == 0)
            {
                return false;
            }
            return true;            
        }
    }
}
