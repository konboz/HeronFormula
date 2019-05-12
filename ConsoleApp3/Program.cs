using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Give side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Give side c: ");
            double c = double.Parse(Console.ReadLine());
            double area = Heron(a, b, c);

            Console.WriteLine("Area of triangle is: {0}", area);

            Console.ReadLine();
        }

        static double Heron(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}
