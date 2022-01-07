using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    //Найти максимальный и минимальный элемент массива
    internal class Task_12
    {
        private readonly int[][] _array;
        private MaxAndMinValue MaxMin;

        public Task_12(int[][] array)
        {
            _array = array;            
        }

        public class MaxAndMinValue
        {
            private readonly int MaxValue;
            private readonly int MinValue;

            public MaxAndMinValue()
            {

            }

            public MaxAndMinValue(int maxValue, int minValue)
            {
                if (maxValue > minValue)
                {
                    MaxValue = maxValue;
                    MinValue = minValue;
                }
                else
                {
                    MaxValue = minValue;
                    MinValue = maxValue;
                }
            }

            public override string? ToString()
            {
                if (string.IsNullOrEmpty(MaxValue.ToString()) || string.IsNullOrEmpty(MinValue.ToString()))
            {
                    return base.ToString();
                }
                string str = $"Минимальный элемент массива {MinValue}, а максимальный {MaxValue}";
                return str;
            }
        }

        

        public MaxAndMinValue MaxAndMinElement()
        {
            var maxValue = int.MinValue;
            var minValue = int.MaxValue;
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
