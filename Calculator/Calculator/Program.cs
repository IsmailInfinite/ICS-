using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char Calc;
            Console.Write("Enter the number:");
             num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number:");
             num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operator:\n + \n - \n * \n / \n");
            Calc = Convert.ToChar(Console.ReadLine());
            switch (Calc)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
            }
            Console.ReadLine();

            }

        }
    }