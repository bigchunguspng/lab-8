using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Base example1 = new Base();
            PrintArraySize(example1);

            example1[3] = 23;
            Console.WriteLine("example1[3]: " + example1[3]);
            PrintArraySize(example1);

            Console.WriteLine("example1[5]: " + example1[5]);
            PrintArraySize(example1);


            Derivative example2 = new Derivative();
            PrintArraySize(example2);

            example2[0, char.MinValue] = 'w';
            example2[1, char.MinValue] = 'a';
            PrintArraySize(example2);

            example2[5, char.MinValue] = 's';
            Console.WriteLine("example2[5 (char)]: " + example2[5, char.MaxValue]);
            example2[0] = 16;
            example2[3] = 37;
            Console.WriteLine("example2[3]: " + example2[3]);
            PrintArraySize(example2);
            Console.WriteLine("exapmle2 chars: " + example2.Chars);

            Console.ReadKey();
        }

        private static void PrintArraySize(Base example) => Console.WriteLine("array size: " + example.Count);

        private static void PrintArraySize(Derivative example)
        {
            Console.WriteLine(" ints size: " + example.Count[0]);
            Console.WriteLine("chars size: " + example.Count[1]);
        }
    }
}