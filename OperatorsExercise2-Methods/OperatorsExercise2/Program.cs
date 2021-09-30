using System;

namespace OperatorsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = AreaOfCircle(10);
            Console.WriteLine(area);

           

        }
        public static double AreaOfCircle(double r)
        {
            double pi = Math.PI;
            double area =  pi * Math.Pow(r, 2);
            return area;
        }
        
        



        
    }
}
