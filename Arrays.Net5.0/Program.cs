using System;

namespace Arrays.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 10;
            grades[3] = 5;
            grades[4] = 0;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);
            Console.ReadKey();
        }
    }
}
