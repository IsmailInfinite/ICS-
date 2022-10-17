using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalornot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter the numbers:");
            num1 =
            Convert.ToInt32(Console.ReadLine());
            num2 =
            Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Are equal");
            else
                Console.WriteLine("not equal");
            Console.ReadLine();
        }
    }
}
