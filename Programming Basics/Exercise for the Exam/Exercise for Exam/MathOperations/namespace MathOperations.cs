using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = decimal.Parse(Console.ReadLine());
            var num2 = decimal.Parse(Console.ReadLine());
            string symb = Console.ReadLine();

            var divi = "";

            
            if (symb == "+")
            {
                var result = num1 + num2;
                if (result % 2 == 0)
                {
                    divi = "even";
                }
                else
                {
                    divi = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symb, num2, result, divi);
            }
            if (symb == "-")
            {
                var result = num1 - num2;
                if (result % 2 == 0)
                {
                    divi = "even";
                }
                else
                {
                    divi = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symb, num2, result, divi);
            }
            if (symb == "*")
            {
                var result = num1 * num2;
                if (result % 2 == 0)
                {
                    divi = "even";
                }
                else
                {
                    divi = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", num1, symb, num2, result, divi);
            }
            if (symb == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                    return;
                    
                }
                decimal result = (num1 / num2);
                Console.WriteLine("{0} {1} {2} = {3:f2}", num1, symb, num2, result);

                // Console.WriteLine("{0} {1} {2} = {3;f2}", num1, symb, num2, result);
            }

            if (symb == "%")
            {
                if (num2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                    return;

                }
                var result = (num1 % num2);
                Console.WriteLine("{0} {1} {2} = {3}", num1, symb, num2, result);

            }
           

        }
    }
}
