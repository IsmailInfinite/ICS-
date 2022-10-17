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
            

            Console.WriteLine("Enter the celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double farenheit =((celsius * 9) / 5) + 32;
            Console.WriteLine("Temperature in Farenheit is:" + farenheit);
            Console.ReadKey();


        }
    }
}
