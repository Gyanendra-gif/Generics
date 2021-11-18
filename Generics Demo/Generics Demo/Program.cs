using System;

namespace Generics_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }
        public static void toPrint<T>(T[] intArray) 
        {
            foreach (var data in intArray)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}

