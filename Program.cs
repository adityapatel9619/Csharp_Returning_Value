using System;

namespace Csharp_Returning_Value
{
    class Program
    {
        //Return Type Method
            //This function is calculating area
        static double returningtest(int r){
            double area = r * r * 3.14;
            return area;

        }

        static void Main(string[] args)
        {
            //The value of radius is initilized
            int radius=5;
            //Here method can be assigned to variable
            double result = returningtest(radius);
            Console.WriteLine("Area is  {0}", result);



        }
    }
}
