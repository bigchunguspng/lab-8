using System;
using System.Globalization;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var example = new DateCalculator { Date = DateTime.Now };
            
            PrintDate(example[-24]);
            PrintDate(example[-24]);
            PrintDate(example[-2]);
            PrintDate(example[0]);
            PrintDate(example[1]);
            PrintDate(example[18]);

            Console.ReadKey();
        }

        private static void PrintDate(DateTime dateTime) => Console.WriteLine(DateOnly(dateTime));
        private static string DateOnly(DateTime dateTime) => dateTime.Date.ToString("dd MMM yyyy", CultureInfo.CurrentCulture);
    }
}