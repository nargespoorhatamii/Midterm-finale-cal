using System;
namespace project
{
    class test
    {
        public static void Main()
        {
            Console.WriteLine("inter the Midterm score");
            double Midterm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inter the finale score");
            double Finale = Convert.ToDouble(Console.ReadLine());
            double show = score(Midterm, Finale);
            Console.WriteLine(show);
        }
        private static double score(double x, double y)
        {
            double Result = 0.35 * x + 0.45 * y;
            if (Result >= 10)
            {
                Console.WriteLine("Pass");
            }
            else
                Console.WriteLine("Failed");
            return Result;
        }
    }

}