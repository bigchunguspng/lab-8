using System;

namespace Task_3
{
    public class Base
    {
        private int[] _array;
        
        public Base()
        {
            _array = new int[1];
            Console.WriteLine("new Base() created");
        }

        public int this[int i]
        {
            get
            {
                if (i >= Count) this[i] = 0;
                return _array[i];
            }
            set
            {
                if (i >= Count)
                {
                    int[] temp = new int[i + 1];
                    for (int j = 0; j < Count; j++)
                        temp[j] = _array[j];
                    _array = temp;
                }
                _array[i] = value;
            }
        }

        public int Count => _array.Length;
    }
}