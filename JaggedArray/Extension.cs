using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    public static class Extension
    {
        public static bool CheckForElement(int [][] array)
        {
            int sum = 0;
            foreach (var item in array)
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
