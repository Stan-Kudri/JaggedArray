using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    public static class ArrayExtension
    {
        public static bool HasElement(this int [][] array)
        {
            int sum = 0;
            sum += array.Select(x => x.Length).Sum();
            if (sum == 0)
            {
                return false;
            }
            return true;
        }
    }
}
