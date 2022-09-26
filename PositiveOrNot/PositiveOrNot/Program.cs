using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number to know if it is positive or negetive\n");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)

                Console.WriteLine("Positive",num);
            
            else
                Console.WriteLine("Negetive",num);
            Console.ReadLine();
        }
    }
}
