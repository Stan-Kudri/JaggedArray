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

        public MaxAndMinValue? MaxAndMinElement()
        {
            if (!_array.HasElement())
                return null;
            int maxValue = _array.SelectMany(x => x).Max(x => x);
            int minValue = _array.SelectMany(x => x).Min(x => x);
            return new MaxAndMinValue(maxValue, minValue); ;
        }

        public class MaxAndMinValue
        {
            private readonly int _maxValue;
            private readonly int _minValue;

            public int MaxValue => _maxValue;
            public int MinValue => _minValue;
            public MaxAndMinValue()
            {

            }
            public MaxAndMinValue(int maxValue, int minValue)
            {
                _maxValue = maxValue;
                _minValue = minValue;
            }

            public override string ToString()
            {
                return $"Min = {_minValue}; Max = {_maxValue}";
            }
        }
    }    
}
