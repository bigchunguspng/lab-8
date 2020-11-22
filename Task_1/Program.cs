using System;

namespace Task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var example = new Coords
            {
                [0] = 28, 
                [1] = 5928, 
                [2] = 7
            };

            Console.WriteLine(example[0]);
            Console.WriteLine(example[1]);
            Console.WriteLine(example[2]);

            Console.ReadKey();
        }
    }
}