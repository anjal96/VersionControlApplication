using System;
using System.Collections.Generic;
using System.Text;


namespace Triangle
{
    public static class TriangleSolver
    {
        public static String Analyze(int side1, int side2, int side3)
        {
            string validate;
            // check condition 
            if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))
            {       
                validate = "the triangle can be form";
                //Check whether a triangle is Equilateral, Isosceles or Scalene
                if (CheckTriangle(side1, side2, side3) == 1)
                {
                    Console.WriteLine("Triangle can be form \n");
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.Write("This is an equilateral triangle.\n");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.Write("This is an isosceles triangle.\n");
                    }
                    else if ((side1 != side2) | (side2 != side3) | (side3 != side1))
                    {
                        Console.Write("This is a scalene triangle.\n");
                    }
                    else
                    {
                        Console.WriteLine("unpredictable triangle");
                    }
                }
                else
                {
                    Console.WriteLine("sorry the given input cannot form a triangle");
                }
            }
                else
                validate = "The Triangle cannot be form";

            return validate;
        }
        // method to check Triangle 
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
