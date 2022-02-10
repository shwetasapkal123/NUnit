using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option from following:\n1.Vending Machine\t2.Day of Week\t3.Temperature Conversion\t4.Monthly Payment\t5.Square Root of non-negative number\t6.Binary Representation\t7.Swap nibble and check resultant Number is power of two");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    VendingMachine machine = new VendingMachine();
                    machine.amount();
                    break;
                case 2:
                    DayOfWeek.DayUsingGeorgianCal(7, 30, 1997);
                    break;
                case 3:
                    TempConversion.TemperatureConversionMethod();
                    Console.WriteLine("Want to continue: type Y or N");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'Y' || ch == 'y')
                        TempConversion.TemperatureConversionMethod();
                    else
                        break;
                    break;
                case 4:
                    MonthlyPay.MonthlyPaymentMethod();
                    break;
                case 5:
                    SquareRoot.FindSqrtNewtonsMethod();
                    break;
                case 6:
                    BinaryRepresentation.DecimalToBinaryConv();
                    break;
                case 7:
                    SwapNibble.ConvToBinary(40);
                    break;
                default:
                    Console.WriteLine("Please choose Correct option");
                    break;
            }
            

            Console.ReadLine();
        }
    }
}
