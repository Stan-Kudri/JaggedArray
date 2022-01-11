using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти максимальный и минимальный элемент массива
    public class Task12
    {
        private readonly int[][] _array;

        public Task12(int[][] array)
        {
            _array = array;            
        }

        public class MaxAndMinValue
        {
            private readonly int _maxValue;
            private readonly int _minValue;
            private readonly bool _exemenationNull;

            public int MaxValue => _maxValue;
            public int MinValue => _minValue;
            public MaxAndMinValue()
            {

            }
            public MaxAndMinValue(int maxValue, int minValue)
            {
                _exemenationNull = true;
                _maxValue = maxValue;
                _minValue = minValue;
            }

            public override string ToString()
            {
                if (!_exemenationNull)
                {
                    return "Array has no elements";
                }
                string str = $"Min = {_minValue}; Max = {_maxValue}";
                return str;
            }
        }
        
        public MaxAndMinValue? MaxAndMinElement()
        {
            var maxValue = int.MinValue;
            var minValue = int.MaxValue;
            if (!CheckForElement())
            {
                return null;
            }
            for (var i = 0; i < _array.Length; i++)
            {
                for (var j = 0; j < _array[i].Length; j++)
                {
                    if (_array[i][j] > maxValue) maxValue = _array[i][j];
                    if (_array[i][j] < minValue) minValue = _array[i][j];
                }
            }
            return new MaxAndMinValue(maxValue, minValue); ;
        }
        private bool CheckForElement()
        {
            int sum = 0;
            foreach (var item in _array)
            {
                sum += item.Length;
            }
            if (sum == 0)
            {
                return false;
            }
            return true;
        }
    }    
}
