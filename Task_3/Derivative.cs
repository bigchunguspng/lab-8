using System;

namespace Task_3
{
    public class Derivative : Base
    {
        private char[] _chars;
        
        public Derivative()
        {
            _chars = new char[1];
            Console.WriteLine("new Derivative() created");
        }

        public char this[int i, char a]
        {
            get
            {
                if (i >= Count[1]) this[i, ' '] = ' ';
                return _chars[i];
            }
            set
            {
                if (i >= Count[1])
                {
                    char[] temp = new char[i + 1];
                    for (int j = 0; j < Count[1]; j++)
                        temp[j] = _chars[j];
                    _chars = temp;
                }
                _chars[i] = value;
            }
        }

        public new int[] Count => new []{base.Count, _chars.Length};

        public string Chars => new string(_chars);
    }
}