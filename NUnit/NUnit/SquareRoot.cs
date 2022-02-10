using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class SquareRoot
    {
        public static void FindSqrtNewtonsMethod()
        {
            Console.WriteLine("Enter the value to find Square root :");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine( "Square root using Newtons Method is: "+t);
        }
    }
}
