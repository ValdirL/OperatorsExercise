using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) ;
            Console.WriteLine($" {a} / {b} is {b} remainder 1"); // ?? Trying to write out result in following form: 17/4 is 4 remainder 1   
            Console.WriteLine($" {a} / {b} is {quotient} remainder {remainder}");

            {
            Console.WriteLine("What is the radius of your cirlce?");
            double radius = double.Parse(Console.ReadLine());
            }

            static double AreaOfCircle(double radius)
            {
            return Math.PI * radius * radius;

            }

        }

    }
}
