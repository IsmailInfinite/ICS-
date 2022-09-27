using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double avg = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("average" + avg);
            Console.WriteLine("Minimum value" + arr.Min());

            Console.WriteLine("Maxmum value" + arr.Max());
            Console.Read();

        }
    }
}
