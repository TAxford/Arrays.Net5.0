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

            /* To allow a user to input 
            string input = Console.Readline();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);
            Console.ReadKey();
             */

            //Another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };
        }
    }
}
