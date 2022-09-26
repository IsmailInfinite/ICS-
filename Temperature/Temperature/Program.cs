using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = 1;

            Console.WriteLine("Enter the celsius", 1);
            Console.WriteLine("Temperature in celsius is :" + celsius);
            float farenheit =((celsius * 9) / 5) + 32;
            Console.WriteLine("Temperature in Farenheit is:" + farenheit);
            Console.ReadKey();


        }
    }
}
