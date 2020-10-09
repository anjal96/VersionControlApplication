using System;
using System.Runtime.Serialization;
using Triangle;

namespace Triangle
{
    class Program
    {
        public static void Main(string[] args)
        {
            //declaring variables
            int input, side1, side2, side3;

            String triangle;         
            //menu for triangle 

            Console.WriteLine("list the functions of menu \n");
            while (true)
            {
                Console.WriteLine("1 = Enter Triangle dimensions");
                Console.WriteLine("2 = EXIT \n");
                Console.WriteLine("please seletct an option from menu \n");

                input = Convert.ToInt32(Console.ReadLine());

                // validating input from user
                switch (input)
                {
                    case 1:
                        Console.WriteLine("please enter the First dimensions ");
                        side1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("please enter the Second dimensions");
                        side2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("please enter the Third dimensions");
                        side3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("the dimensions of a triangle is {0} {1} {2} \n", side1,side2,side3);

                        //calling method to the class functions

                        triangle = TriangleSolver.Analyze(side1, side2, side3);
                        Console.WriteLine(triangle);                       
                        break;
                    case 2:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input please re enter the choice from menu\n");
                        break;
                }
            }
        }
        public static int CheckTriangle(int side1, int side2, int side3)
        {
            // check condition 
            if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
                return 1;
            else
                return 0;
        }

    }
}
