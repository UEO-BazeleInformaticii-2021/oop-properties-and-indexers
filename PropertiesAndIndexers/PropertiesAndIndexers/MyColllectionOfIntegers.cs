using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndIndexers
{
    public class MyColllectionOfIntegers
    {
        private readonly int[] _array;

        public MyColllectionOfIntegers(int[] array)
        {
            if (array is null)
            {
                _array = new int[0];
            }
            else
            {
                _array = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    _array[i] = array[i];
                }
            }
        }

        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public int Min()
        {
            if (_array.Length == 0)
            {
                return int.MinValue;
            }

            int min = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
        }
    }
}
