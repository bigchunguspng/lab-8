using System;

namespace Task_2
{
    public class DateCalculator
    {
        private DateTime _date;

        public DateTime Date
        {
            get => _date;
            set => _date = value.Date;
        }

        public DateTime this[int i] => Date + TimeSpan.FromDays(i);
    }
}