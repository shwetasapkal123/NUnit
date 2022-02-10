using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class MonthlyPay
    {
        public static void MonthlyPaymentMethod()
        {
            Console.WriteLine("Enter the year to pay off : ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Principal amount : ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter percent interest compounded monthly : ");
            double R = Convert.ToDouble(Console.ReadLine());
            double n = 12 * Y;
            double r = R / 12 * 100;
            double num = P * r;
            double den = 1 - Math.Pow(1 + r, -n);
            double payment = num / den;
            Console.WriteLine("Payment: " + payment);
        }
    }
}
