using System;

namespace new_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("solve the equation below \nax + by = e \ncx + dy = f");
            System.Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("b");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("c");
            int c = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("d");
            int d = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("e");
            int e = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("f");
            int f = Convert.ToInt32(Console.ReadLine());

            double g = e*d - f*b;
            double h = a*d - b*c;

            double i = a*f - e*c;
            double j = a*d - b*c;

            double x = g/h;
            double y = i/h;
            if (h == 0)
            {
                System.Console.WriteLine("the equation has no solution");
            }
            else
              {
               System.Console.WriteLine("x is " + x);
               System.Console.WriteLine("y is " + y);
              }
            
        }
    }
}
