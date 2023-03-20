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

            //Third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);


            //Foreach loop

            int[] nums = new int[10];

            for(int i = 0; 1 < 10; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            Console.ReadKey();

        }
    }
}
