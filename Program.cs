using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be multiplied by 50");
            string Inpt = Console.ReadLine();
            int inptNum = Int32.Parse(Inpt);
            int total = 50 * inptNum;
            Console.WriteLine("Result = " + total);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be added to 25");
            string Inpt2 = Console.ReadLine();
            int inptNum2= Int32.Parse(Inpt2);
            int total2 = 25 + inptNum2;
            Console.WriteLine("Result = " + total2);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be divided by 12.5");
            string Inpt3 = Console.ReadLine();
            double inptNum3 =  double.Parse(Inpt3);
            double total3 =  inptNum3 / 12.5;
            Console.WriteLine("Result = " + total3);
            Console.ReadLine();

            Console.WriteLine("Enter a number to check if its greater than 50");
            string Inpt4 = Console.ReadLine();
            int inptNum4 = Int32.Parse(Inpt4);
            bool bool4 = inptNum4 > 50;
            Console.WriteLine("Result = " + bool4.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number to be divided by seven then print remainder to console");
            string Inpt5 = Console.ReadLine();
            int inptNum5 = Int32.Parse(Inpt5);
            float remainder5 = inptNum5 % 7;
            Console.WriteLine("Remainder = " + remainder5.ToString());
            Console.ReadLine();
        }
    }
}
