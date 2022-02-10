using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class TempConversion
    {
        public static void TemperatureConversionMethod()
        {
            Console.WriteLine("Select the option from below :\n1.Temp Conversion from Celsius to Fahrenheit\t2.Temp Conversion from Convert Fahrenheit to Celsius ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the temperature in Celsius: ");
                    double C = Convert.ToDouble(Console.ReadLine());
                    double F = (C * 9 / 5) + 32;
                    Console.WriteLine(C + "°C to " + F + "°F");
                    break;
                case 2:
                    Console.WriteLine("Enter the temperature in Fahrenheit: ");
                    double f = Convert.ToDouble(Console.ReadLine());
                    double c = (f - 32) * 5 / 9;
                    Console.WriteLine(f + "°F to " + c + "°C");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    TemperatureConversionMethod();
                    break;
            }
        }
    }
}
