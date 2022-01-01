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
        private MaxAndMinValue MaxMin;

        public Task12(int[][] array)
        {
            _array = array;            
        }

        public class MaxAndMinValue
        {
            private readonly int? _maxValue;
            private readonly int? _minValue;

            public int? MaxValue => _maxValue;
            public int? MinValue => _minValue;
            public MaxAndMinValue()
            {

            }

            public MaxAndMinValue(int? maxValue, int? minValue)
            {
                if (maxValue > minValue)
                {
                    _maxValue = maxValue;
                    _minValue = minValue;
                }
                else
                {
                    _maxValue = minValue;
                    _minValue = maxValue;
                }
            }

            public override string? ToString()
            {
                if (string.IsNullOrEmpty(_maxValue.ToString()) || string.IsNullOrEmpty(_minValue.ToString()))
            {
                    return base.ToString();
                }
                string str = $"Минимальный элемент массива {_minValue}, а максимальный {_maxValue}";
                return str;
            }
        }
        
        public MaxAndMinValue MaxAndMinElement()
        {
            var maxValue = int.MinValue;
            var minValue = int.MaxValue;
            if (_array.Count() < 1)
            {
                return new MaxAndMinValue(null, null);
            }
            for (var i = 0; i < _array.Length; i++)
            {
                for (var j = 0; j < _array[i].Length; j++)
                {
                    if (_array[i][j] > maxValue) maxValue = _array[i][j];
                    if (_array[i][j] < minValue) minValue = _array[i][j];
                }
            }            
            MaxMin = new MaxAndMinValue(maxValue, minValue);
            return MaxMin;
        }
    }    
}
