using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welome Student \nplease indiate below \nFull-time or part-time");
            string student = Convert.ToString(Console.ReadLine());
            {
                if (student == "full-time")
                {
                    Console.WriteLine("course of study?");
                    string answer = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(answer + " it is a good course");
                }
                else if (student == "part-time")
                {
                    
                
                    {
                        Console.WriteLine("how many credit are you taken?");
                        int credit = Convert.ToInt32(Console.ReadLine());
                         if (credit > 6)
                         System.Console.WriteLine("to much unit");
                         else
                         {
                            System.Console.WriteLine("proceed to screen");
                         }
                   }
                }
                else
                {
                    System.Console.WriteLine(" ERROR \ncrosscheck imput");
                }

            }

        }
    }
}
