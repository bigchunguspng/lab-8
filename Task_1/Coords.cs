using System;

namespace Task_1
{
    public class Coords
    {
        private int _x;
        private int _y;

        private readonly string _errorMessage = "Iндекс має бути 0 або 1";

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return _x;
                    case 1:
                        return _y;
                    default:
                        Console.WriteLine(_errorMessage);
                        return int.MinValue;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        _x = value;
                        break;
                    case 1:
                        _y = value;
                        break;
                    default:
                        Console.WriteLine(_errorMessage);
                        break;
                }
            }
        }
    }
}